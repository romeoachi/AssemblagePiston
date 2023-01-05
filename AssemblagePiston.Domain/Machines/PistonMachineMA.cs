using AssemblagePiston.Domain.Pistons;

namespace AssemblagePiston.Domain.Machines
{
    internal class PistonMachineMA : PistonMachineAbstract
    {
        private static readonly double DURATION_PROCESS = 2.5;

        private PistonMachineMA(double durationProcess, IPiece piece)
            : base(durationProcess, piece)
        {
        }

        public static PistonMachineMA setPiece(IPiece piece)
        {
            return new PistonMachineMA(DURATION_PROCESS, piece);
        }
    }
}