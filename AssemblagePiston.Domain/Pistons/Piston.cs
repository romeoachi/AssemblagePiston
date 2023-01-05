namespace AssemblagePiston.Domain.Pistons
{
    public class Piston
    {
        private readonly PistonMT currentMT;
        private readonly PistonMJ currentMJ;
        private readonly PistonMA currentMA;
        private readonly double durationProcessPiston;

        private Piston(PistonMT currentMT, PistonMJ currentMJ, PistonMA currentMA, double durationProcessPiston)
        {
            this.currentMT = currentMT;
            this.currentMJ = currentMJ;
            this.currentMA = currentMA;
            this.durationProcessPiston = durationProcessPiston;
        }

        public static Piston Set(PistonMT currentMT, PistonMJ currentMJ, PistonMA currentMA, double durationProcessPiston)
        {
            return new Piston(currentMT, currentMJ, currentMA, durationProcessPiston);
        }

        public override string ToString()
        {
            return "Piston{" +
                "itemMT=" + currentMT +
                ", itemMJ=" + currentMJ +
                ", itemMA=" + currentMA +
                ", durationProcess=" + durationProcessPiston +
                '}';
        }

        public double getDurationProcess()
        {
            return durationProcessPiston;
        }
    }
}