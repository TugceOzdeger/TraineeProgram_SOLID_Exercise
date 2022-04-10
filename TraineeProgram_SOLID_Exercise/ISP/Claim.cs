using System;

namespace TraineeProgram_SOLID_Exercise.ISP
{
    public class Claim : IOperation
    {
        public string Activate()
        {
            throw new NotImplementedException();
        }

        public string Calculate()
        {
            throw new NotImplementedException();
        }

        public string Delete()
        {
            return("Claim is successfully deleted.");
        }

        public string Execute()
        {
            throw new NotImplementedException();
        }

        public string Save()
        {
            return("Claim is successfully saved.");
        }
    }
}
