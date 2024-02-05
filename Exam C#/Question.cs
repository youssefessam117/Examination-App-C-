using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class Question
    {
        public string QuestionHead { get; set; }
        public string QuestionBody { get; set; }
        public float Mark { get; set; }
        public Answers[] QAnswer { get; set; }
        public Answers RightAnswer { get; set; }

        public Question(string questionHead, string questionBody, float mark)
        {
            QuestionHead = questionHead;
            QuestionBody = questionBody;
            Mark = mark;
            //QAnswer = answers;
            //RightAnswer = rightAnswer;
            //Answers[] answers, Answers rightAnswer
        }

    }
}
