using AssemblagePiston.Domain.enums;

namespace AssemblagePiston.Domain.Pistons
{
    public class PistonMJ : IPiece
    {
        public EnumTypePiece GetEnumTypePiece()
        {
            return EnumTypePiece.MJ;
        }
    }
}
