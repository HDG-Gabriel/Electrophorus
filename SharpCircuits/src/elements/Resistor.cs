using SharpCircuit.src;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpCircuit.src.elements
{

    public class Resistor : PassiveElement
    {

        /// <summary>
        /// Resistance (ohms)
        /// </summary>
        public double resistance { get; set; }

        public Resistor() : base()
        {
            resistance = 100;
        }

        public Resistor(double r) : base()
        {
            resistance = r;
        }

        public override void calculateCurrent()
        {
            current = (lead_volt[0] - lead_volt[1]) / resistance;
        }

        public override void stamp(Circuit sim)
        {
            sim.stampResistor(lead_node[0], lead_node[1], resistance);
        }

        /*public override void getInfo(String[] arr) {
			arr[0] = "resistor";
			getBasicInfo(arr);
			arr[3] = "R = " + getUnitText(resistance, Circuit.ohmString);
			arr[4] = "P = " + getUnitText(getPower(), "W");
		}*/

    }
}