using AssemblagePiston.Domain.Utils;

namespace AssemblagePiston.Domain.Machines
{
    internal abstract class MachineAbstract
    {
        protected double durationProcess;

        protected MachineAbstract(double durationProcess)
        {
            this.durationProcess = durationProcess + GetDurationExtratTimeIfMachineIsDown();
        }

        private static double GetDurationExtratTimeIfMachineIsDown()
        {
            return RandomUtils.GetExtraTimeDurationTrouble(RandomUtils.IsMachineDown());
        }
    }
}