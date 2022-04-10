namespace TraineeProgram_SOLID_Exercise.DIP
{
    public class Location
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public string ExportData()
        {
            return "Location data exported";
        }
    }
}
