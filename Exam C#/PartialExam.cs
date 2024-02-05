using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class PartialExam : Exam
    {

        public PartialExam(decimal examTime, int questionNumber ) 
        {
            ExamTime = examTime;
            QuestionNumber = questionNumber;
            ExamQuestion = new Question[questionNumber];
        }
        public override void ShowExam()
        {
            Console.Clear();

            for (int i = 0; i < ExamQuestion.Length; i++)
            {
                Console.WriteLine(ExamQuestion[i]);

                Console.WriteLine("---------------------------------");

                int answer;
                bool flag;
                do
                {
                    flag = int.TryParse(Console.ReadLine(), out answer);
                } while (!flag || answer < 1 || answer > 3);
                //AnswerArr[i].AnswerId = answer;
                //if (ExamQuestion[i].RightAnswer.AnswerId == answer)
                //{
                    
                //}
            }
            Console.WriteLine("Your Answers");
            for (int i = 0;i < QuestionNumber;i++)
            {
                Console.WriteLine($"Q{i+1})  {ExamQuestion[i].QuestionBody} : {ExamQuestion[i].RightAnswer.AnswerText}");
            }
        }

    }
}
