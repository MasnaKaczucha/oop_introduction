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
        List<Student> students = new List<Student>();
        internal int StudentCount()
        {

            return students.Count;

        }

        internal double AvgStudentMark()
        {
            return 0;
        }

        internal double AvgStudentMarkAccToSubject(Subject s)
        {
            return 1;
        }

    }
}
