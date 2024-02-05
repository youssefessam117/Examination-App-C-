using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal abstract  class Exam
    {
        public decimal ExamTime { get; set; }
        public int QuestionNumber { get; set; }

        public Question[] ExamQuestion { get; set; }

        public abstract void ShowExam();
    }
}
