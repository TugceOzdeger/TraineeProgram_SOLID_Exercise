using System;

namespace TraineeProgram_SOLID_Exercise.ISP
{
    public class Policy : IOperation
    {
        public string Activate()
        {
            return ("Policy is successfully activated.");
        }

        public string Calculate()
        {
            return ("Policy is successfully calculated.");
        }

        public string Delete()
        {
            return ("Policy is successfully deleted.");
        }

        public string Execute()
        {
            throw new NotImplementedException();
        }

        public string Save()
        {
            return ("Policy is successfully saved.");
        }
    }
}
