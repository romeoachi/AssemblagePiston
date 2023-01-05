using AssemblagePiston.Domain.Pistons;
using AssemblagePiston.Service;

namespace AssemblagePiston.ConsoleApp
{
    internal class Program
    {
        private static readonly int COUNT_OF_EACH_PIECES = 100;
        static void Main(string[] args)
        {
            List<IPiece> pieces = new();

            int count = 0;
            while (count < COUNT_OF_EACH_PIECES)
            {
                pieces.AddRange(new List<IPiece>()
                {
                   new PistonMA(),
                   new PistonMJ(),
                   new PistonMT()
                });

                count++;
            }

            MachineMPService machineMpService = MachineMPService.SetPiecesPiston(pieces);
            Console.WriteLine("Total Duration of Process : " + machineMpService.GetTotalDurationProcess());
        }
    }
}