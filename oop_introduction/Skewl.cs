using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_introduction
{
    //TODO: Write the method's logic
    internal class Skewl
    {
        internal string name;
        internal List<Student> students = new List<Student>();
        internal int StudentCount()
        {

            return students.Count;

        }

        internal double AvgStudentMark()
        {
            int soucet = 0;
            int pocet = 0;
            foreach (var student in students)
            {
                foreach (var grade in student.grades)
                {
                    soucet += grade.value * grade.weight;
                    pocet += grade.weight;
                }
            }
            return soucet / pocet;
        }

        internal double AvgStudentMarkAccToSubject(Subject s)
        {
            int soucet = 0;
            int pocet = 0;
            foreach (var student in students)
            {
                foreach (var grade in student.grades)
                {
                    if(grade.subject == s)
                    {
                        soucet += grade.value * grade.weight;
                        pocet += grade.weight;
                    }
                    
                }
            }
            return soucet / pocet;
        }

    }
}
