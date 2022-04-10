namespace TraineeProgram_SOLID_Exercise.DIP
{
    public class Opportunity
    {
        private Location _location;
        private Risk _risk;

        public Opportunity()
        {
            _risk = new Risk();
            _location = new Location();
        }

        public void Export()
        {
            _location.ExportData();
            _risk.ExportData();
        }
    }
}
