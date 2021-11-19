using SharpCircuit.src;
using SharpCircuit.src.elements;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpCircuit.src.elements.voltage
{

    public class ACVoltageSource : Voltage
    {
        public Circuit.Lead leadPos { get { return lead0; } }
        public Circuit.Lead leadNeg { get { return lead1; } }

        public ACVoltageSource() : base(WaveType.AC)
        {
        }
    }
}