namespace Drofsnar
{
    public class VulnerableBirdHunters : IBird
    {
        public string Name => "Vulnerable Bird Hunter";

        public int Value => 200;

        private int RunningTotal { get; set; }
        public bool IsVulnerable { get; set; } = true;

        public int RunBirdHunterCounter()
        {
            RunningTotal++;
            return RunningTotal;
        }

        public int RunBirdHunterMultiplier()
        {
            var counter = RunBirdHunterCounter();
            return RunningTotal * counter;
        }

    }
}
