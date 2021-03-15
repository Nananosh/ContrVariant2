using System;
using System.Threading.Channels;

namespace Zad_2
{
    public class Student
    {
        private string _name;
        private int _numberGroup;
        private int[] _academicPerfomance = new int[5];

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int NumberGroup
        {
            get => _numberGroup;
            set => _numberGroup = value;
        }

        public int[] AcademicPerfomance
        {
            get => _academicPerfomance;
            set => _academicPerfomance = value;
        }

        public Student(string name, int numberGroup) 
        {
            _name = name;
            _numberGroup = numberGroup;
            _academicPerfomance = new int[5];
        }

        public void Appraisals(int [] appraisals)
        {
            for (int i = 0; i < _academicPerfomance.Length; i++)
            {
                _academicPerfomance[i] = appraisals[i];
                Console.WriteLine(_academicPerfomance[i]);
            }
        }
    }
}