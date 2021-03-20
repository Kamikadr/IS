using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS
{
    class QuestionsModel
    {
        public Trouble turnOffTrouble { get; set; } 
        public Trouble screenTrouble { get; set; }
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
