using SharpCircuit.src.elements;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpCircuit.src.elements.diode
{

    public class LED : Diode
    {

        public LED() : base()
        {
            forwardDrop = LED_DEFAULT_DROP;
            setup();
        }

        /*
		double w = 255 * current / .01;
		if (w > 255) {
			w = 255;
		}
		Color cc = new Color((int) (colorR * w), (int) (colorG * w),(int) (colorB * w));
		*/

        /*public override void getInfo(String[] arr) {
			base.getInfo(arr);
			arr[0] = "LED";
		}*/

    }
}