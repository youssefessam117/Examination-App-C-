using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class McqQuestion : Question
    {
        //public Answers[] QAnswer { get; set; }
        //public Answers RightAnswer { get; set; }

        public McqQuestion(string questionHead, string questionBody, float mark, Answers[] answers, Answers rightAnswer) :base(questionHead,questionBody,mark) 
        {
            QAnswer = answers;
            RightAnswer = rightAnswer;
        }
        public override string ToString()
        {
            //return $"{QuestionHead}  Mark{Mark}\n {QuestionBody}\n {QAnswer}";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{QuestionHead}  Mark{Mark}\n{QuestionBody}");

            foreach (var answer in QAnswer)
            {
                sb.Append(answer.ToString());
            }

            return sb.ToString();
        }
    }
}
