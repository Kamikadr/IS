using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTPC
{
    class QuestionsModel
    {
        public itemsH_Problems[] H_Problems { get; set; }
        public itemsS_Problems[] S_Problems { get; set; }
    }

    class itemsH_Problems
    {
        public string nameOfTrouble { get; set; }
        public itemsQuestions[] questions { get; set; }
    }
    class itemsS_Problems
    {
        public string nameOfTrouble { get; set; }
        public itemsQuestions[] questions { get; set; }
    }
    class itemsQuestions
    {
        public string question { get; set; }
        public string solve { get; set; }
    }

}
