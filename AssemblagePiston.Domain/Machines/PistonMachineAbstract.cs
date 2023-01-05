using AssemblagePiston.Domain.Pistons;
using AssemblagePiston.Domain.Views;

namespace AssemblagePiston.Domain.Machines
{
    internal abstract class PistonMachineAbstract : MachineAbstract 
    {
        protected IPiece piece;
        protected PistonMachineAbstract(double durationProcess, IPiece piece) : base(durationProcess)
        {
            this.piece = piece;
        }

        public InfoProcessPieceView GetInfoProcessPieceView()
        {
            return InfoProcessPieceView.set(this.durationProcess, piece);
        }

    }
}
