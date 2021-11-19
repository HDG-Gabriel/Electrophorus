namespace SharpCircuit.src
{
    public class PassiveElement : CircuitElement
    {
        public Circuit.Lead leadIn { get { return lead0; } }
        public Circuit.Lead leadOut { get { return lead1; } }
    }
}
