using AssemblagePiston.Domain.enums;

namespace AssemblagePiston.Domain.Pistons
{
    public class PistonMT : IPiece
    {
        public EnumTypePiece GetEnumTypePiece()
        {
            return EnumTypePiece.MT;
        }
    }
}
