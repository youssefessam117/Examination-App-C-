using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class TrueFalseQuestion : Question
    {
        
        //public Answers[] QAnswer { get; set; }
        //public Answers RightAnswer { get; set; }

        public TrueFalseQuestion(string questionHead, string questionBody, float mark , Answers rightAnswer) : base(questionHead, questionBody, mark)
        {
            QAnswer = new Answers[]
           {
                new Answers(1, "True"),
                new Answers(2, "False")
           };
            RightAnswer = rightAnswer;
        }

        public override string ToString()
        {
            return $"{QuestionHead}  Mark{Mark}\n {QuestionBody}\n{QAnswer[0].AnswerId}.{QAnswer[0].AnswerText}     {QAnswer[1].AnswerId}.{QAnswer[1].AnswerText}";
        }
    }
}
