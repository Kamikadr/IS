using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS
{
    class QuestionsModel
    {
        public List<Trouble> H_Problems { get; set; } 
        public List<Trouble> S_Problems { get; set; }
    }
    class Trouble 
    {
        public string nameOfTrouble { get; set; }
        public List<Question> questions { get; set; }
    }
    class Question 
    {
        public string question { get; set; }
        public string solve { get; set; }
        public string rightButtonText { get; set; }
        public string leftButtonText { get; set; }
    }
}
