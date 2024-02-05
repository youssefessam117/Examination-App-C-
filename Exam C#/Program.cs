using System.Diagnostics;

namespace Exam_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject subject = new Subject(4, "s1");

            subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do you want to start the Exam (y |n )");

            char startExam;
            bool isChar;
            do
            {
                isChar = char.TryParse(Console.ReadLine(),out startExam);
            } while (!isChar || startExam != 'y' && startExam != 'Y' && startExam != 'n' && startExam != 'N');
            if (startExam ==  'y' || startExam == 'Y')
            {
                Console.WriteLine("d");
                Stopwatch sw = new Stopwatch();
                sw.Start();
                subject.SubjectExam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }
        }
    }
}
