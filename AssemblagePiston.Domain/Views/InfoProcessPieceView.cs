using AssemblagePiston.Domain.Pistons;

namespace AssemblagePiston.Domain.Views
{
    public class InfoProcessPieceView
    {
        private readonly double durationProcess;
        private readonly IPiece piece;

        private InfoProcessPieceView(double durationProcess, IPiece piece)
        {
            this.durationProcess = durationProcess;
            this.piece = piece;
        }

        public static InfoProcessPieceView set(double durationProcess, IPiece piece)
        {
            return new InfoProcessPieceView(durationProcess, piece);
        }

        public double DurationProcess()
        {
            return durationProcess;
        }

        public IPiece getPiece()
        {
            return piece; 
        }
    }
}