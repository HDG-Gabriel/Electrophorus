using SharpCircuit.src.elements.voltage;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpCircuit.src.elements.voltage.rail
{

    public class ClockInput : VoltageInput
    {

        public ClockInput() : base(WaveType.SQUARE)
        {
            maxVoltage = 2.5;
            bias = 2.5;
            frequency = 100;
        }

    }
}