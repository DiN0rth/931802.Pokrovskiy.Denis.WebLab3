using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLab3.Models
{
    public class QuestionsModel
    {
        public double n1;
        public double n2;
        public double answer;
        public string operation;
        public int count;
        public int useranswer;
        public int ranswers;
        public List<string> Answers;
        string[] ListOperations = { "+", "-", "*", "/" };
        public static QuestionsModel Instance = new QuestionsModel();

        public void Begin()
        {
            Random rand = new Random();
            n1 = rand.Next(0, 10);
            n2 = rand.Next(0, 10);
            operation = ListOperations[rand.Next(0, 3)];
            count++;
        }

        public void Accept()
        {
            if (operation == "+")
            {
                answer = n1 + n2;
                if (answer == useranswer)
                    ranswers++;
                Answers.Add("" + n1 + " + " + n2 + " = " + useranswer);
            }
            if (operation == "-")
            {
                answer = n1 - n2;
                if (answer == useranswer)
                    ranswers++;
                Answers.Add("" + n1 + " - " + n2 + " = " + useranswer);
            }
            if (operation == "*")
            {
                answer = n1 * n2;
                if (answer == useranswer)
                    ranswers++;
                Answers.Add("" + n1 + " * " + n2 + " = " + useranswer);
            }
            if (operation == "/")
            {
                if (n2 != 0)
                {
                    answer = n1 / n2;
                    if (answer == useranswer)
                        ranswers++;
                    Answers.Add("" + n1 + " / " + n2 + " = " + useranswer);
                }
            }
        }

        public void Reset()
        {
            count = 0;
            ranswers = 0;
            Answers = new List<string>();
        }
    }
}
