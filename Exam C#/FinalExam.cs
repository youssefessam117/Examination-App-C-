using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class FinalExam : Exam
    {
        public float Grade { get; set; }
        public Answers[] AnswerArr { get; set; }
        public FinalExam(decimal examTime, int questionNumber)
        {
            ExamTime = examTime;
            QuestionNumber = questionNumber;
            Grade = 0;
            ExamQuestion = new Question[questionNumber];
            AnswerArr = new Answers[questionNumber];
        }
        public override void ShowExam()
        {
            Console.Clear();
            float fullMArk = 0;
            for (int i = 0; i < ExamQuestion.Length; i++)
            {
                Console.WriteLine(ExamQuestion[i]);

                Console.WriteLine("---------------------------------");

                int answer;
                bool flag;
                AnswerArr[i] = new Answers();
                if (ExamQuestion[i].QuestionHead == "MCQ")
                {
                    do
                    {
                        flag = int.TryParse(Console.ReadLine(), out answer);
                    } while (!flag || answer < 1 || answer > 3 );
                }
                else
                {
                    do
                    {
                        flag = int.TryParse(Console.ReadLine(), out answer);
                    } while (!flag || answer < 1 || answer > 2);
                }
                fullMArk += ExamQuestion[i].Mark;
                if (ExamQuestion[i].RightAnswer.AnswerId == answer)
                {
                    Grade += ExamQuestion[i].Mark;
                }
            }
            Console.Clear();
            Console.WriteLine("Your Answers");
            for (int i = 0; i < QuestionNumber; i++)
            {
                Console.WriteLine($"Q{i + 1})  {ExamQuestion[i].QuestionBody} : {ExamQuestion[i].RightAnswer.AnswerText}");
            }
            
            Console.WriteLine($"Your Exam Grade Is {Grade} from {fullMArk}");
        }
    }
}
