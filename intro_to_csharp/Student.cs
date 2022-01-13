using System;
namespace intro_to_csharp
{
    public class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGPA)
        {
            name = aName;
            major = aMajor;
            gpa = aGPA;
        }

        public bool honorRoll()
        {
            if (gpa > 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
