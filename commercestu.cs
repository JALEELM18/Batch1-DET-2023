namespace Batch1_DET_2023
{
    internal class CommerceStudent : Student
    {
        public int economices { get; set; }
        public int accounts { get; set; }

        public int banking { get; set; }

        public override double GetAvgMarks()
        {
            return (economices + accounts + banking) / 3;
        }
    }
}
