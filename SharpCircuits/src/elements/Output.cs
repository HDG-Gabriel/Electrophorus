using SharpCircuit.src;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpCircuit.src.elements
{

    public class Output : CircuitElement
    {

        public Circuit.Lead leadIn { get { return base.lead0; } }

        public override int getLeadCount()
        {
            return 1;
        }

        public override double getVoltageDelta()
        {
            return lead_volt[0];
        }

    }
}
