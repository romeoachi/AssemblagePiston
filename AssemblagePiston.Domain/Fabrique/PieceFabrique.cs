using AssemblagePiston.Domain.enums;
using AssemblagePiston.Domain.Machines;
using AssemblagePiston.Domain.Pistons;
using AssemblagePiston.Domain.Views;

namespace AssemblagePiston.Domain.Fabrique
{
    public class PieceFabrique
    {
        public static InfoProcessPieceView make(IPiece piece)
        {
            switch (piece.GetEnumTypePiece())
            {
                case EnumTypePiece.MT:
                    return PistonMachineMT.setPiece(piece).GetInfoProcessPieceView();
                case EnumTypePiece.MA:
                    return PistonMachineMA.setPiece(piece).GetInfoProcessPieceView();
                case EnumTypePiece.MJ:
                    return PistonMachineMJ.setPiece(piece).GetInfoProcessPieceView();
                default: throw new NotSupportedException("Type de pièce non prise en compte par l'usine");
            }
        }
    }
}
