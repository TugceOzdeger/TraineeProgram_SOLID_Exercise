using System;

namespace TraineeProgram_SOLID_Exercise.ISP
{
    public class Invoice : IOperation
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
            return("Invoice is successfully deleted.");
        }

        public string Execute()
        {
            return("Invoice is successfully executed.");
        }

        public string Save()
        {
            return("Invoice is successfully saved.");
        }
    }
}
