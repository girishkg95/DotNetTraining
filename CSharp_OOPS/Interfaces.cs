using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6] { 85, 89, 94, 95, 98, 93 };

            Result objR = new Result();     //Result class is instantiated

            var avg = objR.GetAverageMarks(marks);      //accessing the Result class functionality 
            objR.DisplayAverage(avg);
            objR.ShowGrade(avg);

            Console.ReadKey();
        }
    }
    //All interfaces can have only method prototypes without any concrete definition
    public interface IExam
    {
        double GetAverageMarks(int[] marks);
        void DisplayAverage(double avg);
    }

    public interface IStudent
    {
        void ShowGrade(double avg);
    }

    public class Result : IExam, IStudent
    {
        public void DisplayAverage(double avg)
        {
            Console.WriteLine("The average marks = {0}", avg);
        }

        public double GetAverageMarks(int[] marks)
        {
            int total;
            double avg;
            total = 0;
            for (int i = 0; i < marks.Length; i++)
                total += marks[i];

            avg = total / marks.Length;
            return avg;
        }

        public void ShowGrade(double avg)
        {
            if (avg >= 70.00)
                Console.WriteLine("Passed in distinction");
            else
                Console.WriteLine("Not a distinction");
        }
    }
}
