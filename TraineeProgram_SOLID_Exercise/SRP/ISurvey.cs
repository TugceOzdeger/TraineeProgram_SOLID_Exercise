namespace TraineeProgram_SOLID_Exercise.SRP
{
    interface ISurvey
    {
        int QuestionNumber { get; set; }
        string QuestionText { get; set; }
        char QuestionAnswer { get; set; }

        string SubmitScore();
    }
}
