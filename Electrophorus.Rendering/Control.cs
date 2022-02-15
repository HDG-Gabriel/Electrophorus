using lib = SharpCircuit.src;
using SkiaSharp;
using System.Collections.Generic;
using System.Linq;

namespace Electrophorus.Rendering
{
    public class Control
    {
        // FIXME: I really don't have time to improve this =/. All conect functions should be done using GENERICS.
        public static void Connect(Dictionary<SKPoint, int> locations, List<CircuitComponent> elements, lib.Circuit circuit)
        {
            foreach (var key in locations.Keys)
            {
                if (locations[key] >= 2)
                {
                    var el = elements.Where(e => e.NodeIn.Location == key || e.NodeOut.Location == key).ToList();
                    foreach (var c1 in el)
                    {
                        foreach (var c2 in el)
                        {
                            if (c1.Equals(c2)) continue;

                            if (c1.TypeElement == ElementType.Passive && c2.TypeElement == ElementType.Passive)
                            {
                                Connect(c1, c2, (lib.PassiveElement)c1.Element, (lib.PassiveElement)c2.Element, circuit);
                            }
                            else if (c1.TypeElement == ElementType.Passive && c2.TypeElement == ElementType.Active)
                            {
                                Connect(c1, c2, (lib.PassiveElement)c1.Element, (lib.ActiveElement)c2.Element, circuit);
                            }
                            else if (c1.TypeElement == ElementType.Active && c2.TypeElement == ElementType.Active)
                            {
                                Connect(c1, c2, (lib.ActiveElement)c1.Element, (lib.ActiveElement)c2.Element, circuit);
                            }
                        }
                    }
                }
            }
        }

        private static void Connect<T>(CircuitComponent c1, CircuitComponent c2, T w0, T w1, lib.Circuit circuit)
            where T : lib.PassiveElement
        {
            if (c1.NodeIn.Location == c2.NodeIn.Location)
            {
                circuit.Connect(w0.leadIn, w1.leadIn);
            }
            else if (c1.NodeIn.Location == c2.NodeOut.Location)
            {
                circuit.Connect(w0.leadIn, w1.leadOut);
            }
            else if (c1.NodeOut.Location == c2.NodeIn.Location)
            {
                circuit.Connect(w0.leadOut, w1.leadIn);
            }
            else
            {
                circuit.Connect(w0.leadOut, w1.leadOut);
            }
            LockSide(c1, c2);
        }

        private static void Connect<T, K>(CircuitComponent c1, CircuitComponent c2, T r, K s, lib.Circuit circuit)
            where T : lib.PassiveElement
            where K : lib.ActiveElement
        {
            if (c1.NodeIn.Location == c2.NodeIn.Location)
            {
                circuit.Connect(r.leadIn, s.leadNeg);
            }
            else if (c1.NodeIn.Location == c2.NodeOut.Location)
            {
                circuit.Connect(r.leadIn, s.leadPos);
            }
            else if (c1.NodeOut.Location == c2.NodeIn.Location)
            {
                circuit.Connect(r.leadOut, s.leadNeg);
            }
            else
            {
                circuit.Connect(r.leadOut, s.leadPos);
            }
            LockSide(c1, c2);
        }

        private static void Connect(CircuitComponent c1, CircuitComponent c2, lib.ActiveElement s0, lib.ActiveElement s1, lib.Circuit circuit)
        {
            if (c1.NodeIn.Location == c2.NodeIn.Location)
            {
                circuit.Connect(s0.leadNeg, s1.leadNeg);
            }
            else if (c1.NodeIn.Location == c2.NodeOut.Location)
            {
                circuit.Connect(s0.leadNeg, s1.leadPos);
            }
            else if (c1.NodeOut.Location == c2.NodeIn.Location)
            {
                circuit.Connect(s0.leadPos, s1.leadNeg);
            }
            else
            {
                circuit.Connect(s0.leadPos, s1.leadPos);
            }
            LockSide(c1, c2);
        }

        // It will lock a side from component
        private static void LockSide(CircuitComponent c1, CircuitComponent c2)
        {
            if (c1.NodeIn.Location == c2.NodeIn.Location)
            {
                c1.IsLeftLocked = true;
                c2.IsLeftLocked = true;
            }
            else if (c1.NodeIn.Location == c2.NodeOut.Location)
            {
                c1.IsLeftLocked = true;
                c2.IsRightLocked = true;
            }
            else if (c1.NodeOut.Location == c2.NodeIn.Location)
            {
                c1.IsRightLocked = true;
                c2.IsLeftLocked = true;
            }
            else
            {
                c1.IsRightLocked = true;
                c2.IsRightLocked = true;
            }
        }
        // TODO: Disconect element
    }
}
