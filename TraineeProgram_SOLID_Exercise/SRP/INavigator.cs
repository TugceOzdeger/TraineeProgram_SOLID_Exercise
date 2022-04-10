namespace TraineeProgram_SOLID_Exercise.SRP
{
    interface INavigator : ISurvey
    {
        int Score { get; set; }
        bool IsRecommendationNeeded { get; set; }

        void something();


    }
}
