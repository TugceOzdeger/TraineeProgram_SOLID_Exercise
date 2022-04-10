namespace TraineeProgram_SOLID_Exercise.SRP
{
    public class Survey : ISurvey
    {
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public char QuestionAnswer { get; set; }

        public string SubmitScore()
        {
            return ("Survey score submitted");
        }
    }
}
