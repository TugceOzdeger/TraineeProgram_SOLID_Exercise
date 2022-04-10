using System;
using TraineeProgram_SOLID_Exercise.LSP;
using TraineeProgram_SOLID_Exercise.OSP;
using TraineeProgram_SOLID_Exercise.SRP;

namespace TraineeProgram_SOLID_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //DIP Principle

            //ISP Principle

            //LSP Principle
            Recommendation rec = new Observation();
            Console.WriteLine(rec.PublishDocument());
            Console.ReadLine();

            //OSP Principle
            PropertyPolicy policy = new PropertyPolicy("LP01");
            Console.WriteLine(policy.Activate());
            Agreement ag = new Agreement("LA01");
            Console.WriteLine(ag.Activate());

            //SRP Principle
            Navigator nav = new Navigator();
            Console.WriteLine(nav.SubmitScore());
            Survey survey = new Survey();
            Console.WriteLine(survey.SubmitScore());
            Console.ReadLine();

        }
    }
}
