namespace TraineeProgram_SOLID_Exercise.OSP
{
    public class PropertyPolicy
    {
        private readonly Business Business;

        public PropertyPolicy(string policyNumber)
        {
            PolicyNumber = policyNumber;
            Business = new Business() { BusinessType = BusinessTypeEnum.Captive };
        }

        public string PolicyNumber { get; }

        public string Activate()
        {
            return $"{PolicyNumber} that has {Business.BusinessType} business has been excuted successfully";
        }
    }
}
