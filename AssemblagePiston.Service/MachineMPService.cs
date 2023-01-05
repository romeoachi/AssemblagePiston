using AssemblagePiston.Domain.enums;
using AssemblagePiston.Domain.Fabrique;
using AssemblagePiston.Domain.Pistons;
using AssemblagePiston.Domain.Utils;
using AssemblagePiston.Domain.Views;

namespace AssemblagePiston.Service
{
    public class MachineMPService
    {
        private List<InfoProcessPieceView> pistonMAS = new();
        private List<InfoProcessPieceView> pistonMTS = new();
        private List<InfoProcessPieceView> pistonMJS = new();

        private readonly List<Piston> pistons = new();
        private static readonly double DURATION_PROCESS = 1;

        public static MachineMPService SetPiecesPiston(List<IPiece> pieces)
        {
            return new MachineMPService(pieces);
        }

        public double GetTotalDurationProcess()
        {
            return pistons.Sum(p => p.getDurationProcess());
        }



        private MachineMPService(List<IPiece> pieces)
        {
            FilterAndMakePiecesProcess(pieces);
            MergetPistonPieces();

        }

        private void MergetPistonPieces()
        {
           while(pistonMAS.Any() && pistonMTS.Any() && pistonMJS.Any())
            {

                var currentMT = pistonMTS.First();
                var currentMJ = pistonMJS.First();
                var currentMA = pistonMAS.First();

                var durationProcessPiston = GetMaxDurationCurrentProcessMergePistonItems(currentMT, currentMJ, currentMA) + GetCurrentDurationMachineMPByProcess();

                pistons.Add(AssemblagePiston((PistonMT)currentMT.getPiece(), (PistonMJ)currentMJ.getPiece(), (PistonMA)currentMA.getPiece(), durationProcessPiston));
               
                RemovePiecesAlreadyAssembled(currentMT, currentMJ, currentMA);
            }
        }
        private static Piston AssemblagePiston(PistonMT currentMT, PistonMJ currentMJ, PistonMA currentMA, double durationProcessPiston)
        {
            return Piston.Set(currentMT, currentMJ, currentMA, durationProcessPiston);
        }

        private void RemovePiecesAlreadyAssembled(InfoProcessPieceView currentMT, InfoProcessPieceView currentMJ, InfoProcessPieceView currentMA)
        {
            pistonMTS.Remove(currentMT);
            pistonMJS.Remove(currentMJ);
            pistonMAS.Remove(currentMA);
        }

        private static double GetCurrentDurationMachineMPByProcess()
        {
            return RandomUtils.GetExtraTimeDurationTrouble(RandomUtils.IsMachineDown()) + DURATION_PROCESS;
        }

        private static double GetMaxDurationCurrentProcessMergePistonItems(InfoProcessPieceView pistonMTView, InfoProcessPieceView pistonMJView, InfoProcessPieceView pistonMAView)
        {
            List<double> durationsValues = new List<double>() { pistonMTView.DurationProcess(), pistonMJView.DurationProcess(), pistonMAView.DurationProcess() };
            return durationsValues.Max();
        }

        private void FilterAndMakePiecesProcess(List<IPiece> pieces)
        {
            pistonMAS = pieces.Where(p=> p.GetEnumTypePiece() == EnumTypePiece.MA).Select(p => PieceFabrique.make(p)).ToList();
            pistonMTS = pieces.Where(p=> p.GetEnumTypePiece() == EnumTypePiece.MT).Select(p => PieceFabrique.make(p)).ToList();
            pistonMJS = pieces.Where(p=> p.GetEnumTypePiece() == EnumTypePiece.MJ).Select(p => PieceFabrique.make(p)).ToList();
        }

    }
}
