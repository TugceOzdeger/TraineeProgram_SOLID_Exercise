namespace TraineeProgram_SOLID_Exercise.DIP
{
    public class Risk
    {
        public decimal MaximumLoss { get; set; }
        public decimal RiskFactor { get; set; }

        public string ExportData()
        {
            return "Risk data exported";
        }
    }
}
