namespace TraineeProgram_SOLID_Exercise.SRP
{
    public class Navigator : INavigator
    {
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public char QuestionAnswer { get; set; }
        public int Score { get; set; }
        public bool IsRecommendationNeeded { get; set; }

        public void something()
        {
            throw new System.NotImplementedException();
        }

        public string SubmitScore()
        {
            return("Navigator score submitted");
        }
    }
}
