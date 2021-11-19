using SharpCircuit.src;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpCircuit.src.elements
{

    public class Wire : PassiveElement
    {
        public override void stamp(Circuit sim)
        {
            sim.stampVoltageSource(lead_node[0], lead_node[1], voltSource, 0);
        }

        public override int getVoltageSourceCount()
        {
            return 1;
        }

        public override double getVoltageDelta()
        {
            return lead_volt[0];
        }

        public override bool isWire()
        {
            return true;
        }

    }
}