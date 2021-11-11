using lib = SharpCircuit.src;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                            if (c1 is Wire wire && c2 is Resistor resistor)
                            {
                                Connect(wire, resistor, circuit);
                            }
                            else if (c1 is Wire wire1 && c2 is Source source)
                            {
                                Connect(wire1, source, circuit);
                            }
                            else if (c1 is Wire wire2 && c2 is Wire wire3)
                            {
                                Connect(wire2, wire3, circuit);
                            }
                            else if (c1 is Resistor resistor1 && c2 is Source source1)
                            {
                                Connect(resistor1, source1, circuit);
                            }
                            else if (c1 is Resistor resistor2 && c2 is Resistor resistor3)
                            {
                                Connect(resistor2, resistor3, circuit);
                            }
                            else if (c1 is Source source2 && c2 is Source source3)
                            {
                                Connect(source2, source3, circuit);
                            }
                        }
                    }
                }
            }
        }
        private static void Connect(Wire c1, Wire c2, lib.Circuit circuit)
        {
            var w0 = c1.Element;
            var w1 = c2.Element;
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
        }

        private static void Connect(Wire c1, Resistor c2, lib.Circuit circuit)
        {
            var w = c1.Element;
            var r = c2.Element;
            if (c1.NodeIn.Location == c2.NodeIn.Location)
            {
                circuit.Connect(w.leadIn, r.leadIn);
            }
            else if (c1.NodeIn.Location == c2.NodeOut.Location)
            {
                circuit.Connect(w.leadIn, r.leadOut);
            }
            else if (c1.NodeOut.Location == c2.NodeIn.Location)
            {
                circuit.Connect(w.leadOut, r.leadIn);
            }
            else
            {
                circuit.Connect(w.leadOut, r.leadOut);
            }
        }

        private static void Connect(Wire c1, Source c2, lib.Circuit circuit)
        {
            var w = c1.Element;
            var s = c2.Element;
            if (c1.NodeIn.Location == c2.NodeIn.Location)
            {
                circuit.Connect(w.leadIn, s.leadNeg);
            }
            else if (c1.NodeIn.Location == c2.NodeOut.Location)
            {
                circuit.Connect(w.leadIn, s.leadPos);
            }
            else if (c1.NodeOut.Location == c2.NodeIn.Location)
            {
                circuit.Connect(w.leadOut, s.leadNeg);
            }
            else
            {
                circuit.Connect(w.leadOut, s.leadPos);
            }
        }

        private static void Connect(Resistor c1, Source c2, lib.Circuit circuit)
        {
            var r = c1.Element;
            var s = c2.Element;
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
        }
        
        private static void Connect(Resistor c1, Resistor c2, lib.Circuit circuit)
        {
            var r0 = c1.Element;
            var r1 = c2.Element;
            if (c1.NodeIn.Location == c2.NodeIn.Location)
            {
                circuit.Connect(r0.leadIn, r1.leadIn);
            }
            else if (c1.NodeIn.Location == c2.NodeOut.Location)
            {
                circuit.Connect(r0.leadIn, r1.leadOut);
            }
            else if (c1.NodeOut.Location == c2.NodeIn.Location)
            {
                circuit.Connect(r0.leadOut, r1.leadIn);
            }
            else
            {
                circuit.Connect(r0.leadOut, r1.leadOut);
            }
        }
        
        private static void Connect(Source c1, Source c2, lib.Circuit circuit)
        {
            var s0 = c1.Element;
            var s1 = c2.Element;
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
        }

        // TODO: Disconect element
    }
}
