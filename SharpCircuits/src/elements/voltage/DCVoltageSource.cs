using SharpCircuit.src;
using SharpCircuit.src.elements;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpCircuit.src.elements.voltage
{

    public class DCVoltageSource : ActiveElement
    {
        public override double Value
        {
            get => maxVoltage;
            set => maxVoltage = value;
        }
        public DCVoltageSource() : base(WaveType.DC)
        {

        }
    }
}