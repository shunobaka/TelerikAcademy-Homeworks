//-----------------------------Problem 1. Student class-----------------------------

//Define a class Student, which contains data about a student
// – first, middle and last name, SSN, permanent address, mobile phone e-mail, course,
//   specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

//-----------------------------Problem 2. IClonable---------------------------------

//Add implementations of the ICloneable interface.
//The Clone() method should deeply copy all object's fields into a new object of type Student.

//-----------------------------Problem 3. IComparable-------------------------------

//Implement the IComparable<Student> interface to compare students by names
//(as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

namespace StudentSystem
{
    using System;
    using Enumarations;

    class StudentsTest
    {
        static void Main()
        {
            Student stOne = new Student("Ivan", "Stoqnov", "Georgiev", 133713371) 
            {
                Phone = 887843423, 
                Univerity = University.Sofiiski,
                Speciality = Speciality.Psihologiq,
                Faculty = Faculty.Filosofski,
                Course = "Filosofiq",
                Address = "Mladost 3",
                Email = "IvanTurboto@abv.bg",
            };
            Student stTwo = new Student("Ivan", "Petrov", "Georgiev", 420);
            Student stThree = new Student("Pesho", "Peshev", "Goshev", 30);
            Student stFour = (Student)stOne.Clone();

            stOne.Email = "NovEmail@gmail.com";

            Console.WriteLine("Student one equal to student two: {0}",stOne.Equals(stTwo));
            Console.WriteLine("Student one equal to student two: {0}", stOne == stTwo);
            Console.WriteLine("Student one not equal to student three: {0}", stOne != stThree);
            Console.WriteLine("Student one equal to student three: {0}", stOne.Equals(stThree));

            Console.WriteLine(Environment.NewLine + "GetHashCode:");
            Console.WriteLine(stOne.GetHashCode());
            Console.WriteLine(Environment.NewLine + "Student.ToString():" + Environment.NewLine);
            Console.WriteLine(stOne.ToString());
            Console.WriteLine(Environment.NewLine + "Cloned student:" + Environment.NewLine);
            Console.WriteLine(stFour);

            Console.Write(Environment.NewLine + "Student one compared to student two: ");
            Console.WriteLine(stOne.CompareTo(stTwo));
        }
    }
}
