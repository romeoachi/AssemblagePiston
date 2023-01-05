using AssemblagePiston.Domain.Pistons;

namespace AssemblagePiston.Domain.Machines
{
    internal class PistonMachineMJ : PistonMachineAbstract
    {
        private static readonly double DURATION_PROCESS = 3;

        private PistonMachineMJ(double durationProcess, IPiece piece)
            : base(durationProcess, piece)
        {
        }

        public static PistonMachineMJ setPiece(IPiece piece)
        {
            return new PistonMachineMJ(DURATION_PROCESS, piece);
        }
    }
}