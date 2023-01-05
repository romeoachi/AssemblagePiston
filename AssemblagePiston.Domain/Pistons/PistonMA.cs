using AssemblagePiston.Domain.enums;

namespace AssemblagePiston.Domain.Pistons
{
    public class PistonMA : IPiece
    {
        public EnumTypePiece GetEnumTypePiece()
        {
            return EnumTypePiece.MA;
        }
    }
}
