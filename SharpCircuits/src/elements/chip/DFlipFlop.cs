using SharpCircuit.src;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpCircuit.src.elements.chip
{

    public class DFlipFlop : Chip
    {

        public Circuit.Lead leadD { get { return lead0; } }
        public Circuit.Lead leadQ { get { return lead1; } }
        public Circuit.Lead leadQL { get { return new Circuit.Lead(this, 2); } }
        public Circuit.Lead leadCLK { get { return new Circuit.Lead(this, 3); } }
        public Circuit.Lead leadR
        {
            get
            {
                if (!hasResetPin)
                    throw new Exception("DFlipFlop doesn't have reset pin");

                return new Circuit.Lead(this, 4);
            }
        }

        public Circuit.Lead leadS
        {
            get
            {
                if (!hasSetPin)
                    throw new Exception("DFlipFlop doesn't have set pin");

                return new Circuit.Lead(this, hasResetPin ? 5 : 4);
            }
        }

        public bool hasResetPin
        {
            get
            {
                return _hasReset;
            }
            set
            {
                _hasReset = value;
                setupPins();
            }
        }

        public bool hasSetPin
        {
            get
            {
                return _hasSet;
            }
            set
            {
                _hasSet = value;
                setupPins();
            }
        }

        private bool _hasReset;
        private bool _hasSet;

        public override string getChipName()
        {
            return "D flip-flop";
        }

        public override void setupPins()
        {
            pins = new Pin[getLeadCount()];

            pins[0] = new Pin("D");

            pins[1] = new Pin(" Q");
            pins[1].output = true;

            pins[2] = new Pin("|Q");
            pins[2].output = true;
            pins[2].lineOver = true;

            pins[3] = new Pin("");
            pins[3].clock = true;

            if (hasResetPin)
                pins[4] = new Pin("R");

            if (hasSetPin)
                pins[hasResetPin ? 5 : 4] = new Pin("S");

            allocLeads();
        }

        public override int getLeadCount()
        {
            return 4 + (hasResetPin ? 1 : 0) + (hasSetPin ? 1 : 0);
        }

        public override int getVoltageSourceCount()
        {
            return 2;
        }

        public override void reset()
        {
            base.reset();
            lead_volt[2] = 5;
            pins[2].value = true;
        }

        public override void execute(Circuit sim)
        {
            if (pins[3].value && !lastClock)
            {
                Debug.Log("flip", pins[3].value, pins[0].value);
                pins[1].value = pins[0].value;
                pins[2].value = !pins[0].value;
            }
            if (hasSetPin && pins[hasResetPin ? 5 : 4].value)
            {
                pins[1].value = true;
                pins[2].value = false;
            }
            if (hasResetPin && pins[4].value)
            {
                pins[1].value = false;
                pins[2].value = true;
            }
            lastClock = pins[3].value;
        }

    }
}