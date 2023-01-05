namespace AssemblagePiston.Domain.Utils
{
    public class RandomUtils
    {
        private static readonly int MIN_CHANCE = 0;
        private static readonly int MAX_CHANCE = 4;

        private static readonly int MIN_TIME_REPARATION = 5;
        private static readonly int MAX_TIME_REPARATION = 11;


        private readonly static Random _rand = new Random();
        private RandomUtils() { }

        public static bool IsMachineDown()
        {
            return _rand.Next(MIN_CHANCE, MAX_CHANCE) == 0;
        }

        public static double GetExtraTimeDurationTrouble(bool isMachineDown)
        {
            if (isMachineDown)
                return _rand.Next(MIN_TIME_REPARATION, MAX_TIME_REPARATION);
            return default;
        }

    }
}
