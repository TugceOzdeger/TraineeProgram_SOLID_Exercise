namespace TraineeProgram_SOLID_Exercise.OSP
{
    public class Agreement
    {
        private readonly Business Business;

        public Agreement(string agreementNumber)
        {
            AgreementNumber = agreementNumber;
            Business = new Business() { BusinessType = BusinessTypeEnum.Captive };
        }

        public string AgreementNumber { get; }

        public string Activate()
        {
            return $"{AgreementNumber} that has {Business.BusinessType} business has been excuted successfully";
        }
    }
}
