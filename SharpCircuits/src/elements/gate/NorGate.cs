using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpCircuit.src.elements.gate
{

    public class NorGate : OrGate
    {

        public override bool isInverting() { return true; }

    }
}