using AssemblagePiston.Domain.Pistons;

namespace AssemblagePiston.Domain.Machines
{
    internal class PistonMachineMT : PistonMachineAbstract
    {
        private static readonly double DURATION_PROCESS = 2;

        private PistonMachineMT(double durationProcess, IPiece piece) 
            : base(durationProcess, piece)
        {
        }

        public static PistonMachineMT setPiece(IPiece piece)
        {
            return new PistonMachineMT(DURATION_PROCESS, piece);
        }
    }
}