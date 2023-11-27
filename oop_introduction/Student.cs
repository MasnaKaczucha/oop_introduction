using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_introduction
{
    internal class Student
    {
        internal string name;
        internal string surname;
        // actually year of birth cuz no time for rodne cislo
        internal int personal_id_num;
        internal List<Grade> grades = new List<Grade>();

        internal int Vek() { 
            return 2023 - personal_id_num; 
        }
    }
}
