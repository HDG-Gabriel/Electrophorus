using SharpCircuit.src;
using SharpCircuit.src.elements;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpCircuit.src.elements.voltage
{

    public class DCVoltageSource : ActiveElement
    {
        public DCVoltageSource() : base(WaveType.DC)
        {

        }
    }
}