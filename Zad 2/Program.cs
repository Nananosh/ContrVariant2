using System;

namespace Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Никита", 916);
            student.Appraisals(new []{5,5,5,5,5});
        }
    }
}