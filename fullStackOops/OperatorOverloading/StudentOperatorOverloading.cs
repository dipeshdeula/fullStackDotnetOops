using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.OperatorOverloading
{
    public class StudentOperatorOverloading
    {
        //unary and binary relationship of student class with attribute of : name, age, rolls
        //another question kun kun operator lai overload garna sakindaina

        //fields
        public string Name;
        public int Age;
        public int Rolls;

        //construcotr
        public StudentOperatorOverloading(string name, int age, int rolls)
        {
            Name = name;
            Age = age;
            Rolls = rolls;
        }

        //overloading unary operator
        public static StudentOperatorOverloading operator ++(StudentOperatorOverloading student)
        {
            student.Rolls = student.Rolls + 1;
            return student;
        }

        public static StudentOperatorOverloading operator --(StudentOperatorOverloading student)
        {
            student.Rolls = student.Rolls - 1;
            return student;
        }

        //overloading binary operator
        public static StudentOperatorOverloading operator +(StudentOperatorOverloading student1, StudentOperatorOverloading student2)
        {
            StudentOperatorOverloading student = new StudentOperatorOverloading(" ", 0, 0);
            student.Rolls = student1.Rolls + student2.Rolls;
            return student;
        }
    }
}
