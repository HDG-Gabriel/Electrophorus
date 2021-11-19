using SharpCircuit.src.elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCircuit.src
{
    public class ActiveElement : Voltage
    {
        public Circuit.Lead leadPos { get { return lead0; } }
        public Circuit.Lead leadNeg { get { return lead1; } }

        public ActiveElement(WaveType wf) : base(wf)
        {

        }
    }
}
