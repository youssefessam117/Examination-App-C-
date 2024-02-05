using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C_
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        #region Methods
        int GetType(string meassage)
        {
            int type;
            bool isNum;
            //Console.Write("please Enter The Type of the Exam  1 for Practial and 2 for Final :");

            Console.Write(meassage);
            do
            {
                isNum = int.TryParse(Console.ReadLine(), out type);
            } while (!isNum || type > 2 || type < 1);
            return type;
        }
        int GetQuestionNum()
        {
            int QuesNum;
            bool isNum;
            Console.Write("please Enter Number of Question :");
            do
            {
                isNum = int.TryParse(Console.ReadLine(), out QuesNum);
            } while (!isNum || QuesNum > 5 || QuesNum < 1);
            return QuesNum;
        }
        int GetExamTime()
        {
            int examTime;
            bool isNum;
            Console.Write("please Enter Exam time In Minutes :");
            do
            {
                isNum = int.TryParse(Console.ReadLine(), out examTime);
            } while (!isNum || examTime < 1);
            return examTime;
        }

        void GnerateMcq(int i, Exam subjectExam)
        {
            //for (int i = 0; i < questionNum; i++)
            //{
                Console.Write($"please Enter the body of quistion {i + 1} :");
                string questionBody = ForceUserToGetString();
                float mark;
                bool isDouble;
                Console.Write($"please Enter the Mark of quistion {i + 1} :");
                do
                {
                    isDouble = float.TryParse(Console.ReadLine(), out mark);
                } while (!isDouble || mark < 0);
                Answers[] answers = new Answers[3];
                Console.WriteLine($"the Choices of Question{i + 1} :");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"please Enter the Choices number {j + 1} :");
                    string choice = ForceUserToGetString();
                    answers[j] = new Answers(j + 1, choice);
                }
                ///Console.Write($"please Enter the Choices number 1 :");
                ///string choice1 = Console.ReadLine() ?? "";
                ///Console.Write($"please Enter the Choices number 2 :");
                ///string choice2 = Console.ReadLine() ?? "";
                ///Console.Write($"please Enter the Choices number 3 :");
                ///string choice3 = Console.ReadLine() ?? "";

                Console.Write($"please Enter the Right Chooce number:");
                int rightChoice;
                bool isNum;
                do
                {
                    isNum = int.TryParse(Console.ReadLine(), out rightChoice);
                } while (!isNum || rightChoice > 3 || rightChoice < 1);

                Answers rightAnswer = new Answers(rightChoice, answers[rightChoice - 1].AnswerText);
                Question question = new McqQuestion("MCQ", questionBody, mark, answers, rightAnswer);
                subjectExam.ExamQuestion[i] = question;
            //}
        }

        string ForceUserToGetString()
        {
            string userInput;

            do
            {
                userInput = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(userInput));

            return userInput;
        }
        #endregion

        public void CreateExam()
        {
            int examType = GetType("please Enter The Type of the Exam  1 for Practial and 2 for Final :");
            int questionNum = GetQuestionNum();
            int examTime = GetExamTime();

            if (examType == 1)
            {
                //this.SupjectExam = new PartialExam();
                SubjectExam = new PartialExam(examTime, questionNum);
                for (int i = 0; i < questionNum; i++)
                {
                    GnerateMcq(i, SubjectExam);
                }
                //SubjectExam.ExamQuestion[i]
            }
            else
            {
                //this.SupjectExam = new FinalExam();
                SubjectExam = new FinalExam(examTime,questionNum);
                for (int i = 0; i < questionNum; i++)
                {
                    int questionType = GetType($"please choose the type of the question num {i + 1} (1 for True or False || 2 for MCQ)  :");
                    if (questionType == 1)
                    {
                        Console.Write($"please Enter the body of quistion {i + 1} :");
                        string questionBody = ForceUserToGetString();
                        float mark;
                        bool isDouble;
                        Console.Write($"please Enter the Mark of quistion {i + 1} :");
                        do
                        {
                            isDouble = float.TryParse(Console.ReadLine(), out mark);
                        } while (!isDouble || mark < 0);
                        int isInt = GetType($"please Enter the Right answer of quistion {i + 1} ( 1 for True and 2 for false ):");
                        Answers rightAnswer = new Answers(isInt,isInt == 1 ? "True":"false");
                        TrueFalseQuestion question = new TrueFalseQuestion("True || False question",questionBody,mark, rightAnswer);
                        SubjectExam.ExamQuestion[i] = question;
                    }
                    else
                    {
                        GnerateMcq(i, SubjectExam);
                    }

                    
                }

            }



        }
    }
}
