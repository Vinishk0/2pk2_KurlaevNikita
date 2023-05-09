using System;

namespace pz28
{
    class Student
    {
        private int[] grades;
        private double averageGrade = -1.0;

        public event EventHandler<string> GradeAdded;

        public void AddGrade(int grade)
        {
            if (grades == null)
            {
                grades = new int[] { grade };
            }
            else
            {
                int[] newGrades = new int[grades.Length + 1];
                Array.Copy(grades, newGrades, grades.Length);
                newGrades[newGrades.Length - 1] = grade;
                grades = newGrades;
            }

            CalculateAverageGrade();
            GradeAdded?.Invoke(this, $"Добавлена оценка: {grade}");
            Console.WriteLine($"Средний балл ученика: {Math.Round(averageGrade, 2)}");
        }

        private void CalculateAverageGrade()
        {
            if (grades != null && grades.Length > 0)
            {
                double sum = 0;
                foreach (int grade in grades)
                {
                    sum += grade;
                }
                averageGrade = sum / grades.Length;
            }
            else
            {
                averageGrade = 0.0;
            }
        }

        public double GetAverageGrade()
        {
            return averageGrade;
        }
    }

    class Teacher
    {
        public Teacher(Student student)
        {
            student.GradeAdded += CheckGrades;
        }

        private void CheckGrades(object sender, string gradeAddedMessage)
        {
            Student student = (Student)sender;
            double averageGrade = student.GetAverageGrade();

            if (averageGrade <= 2.4 && averageGrade != -1)
            {
                Console.WriteLine("Предупреждение: Низкая успеваемость студента!");
            }

            Console.WriteLine(gradeAddedMessage);
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student();
            Teacher teacher = new Teacher(student);

            while (true)
            {
                Console.Write("Введите оценку студента: ");
                int input = Convert.ToInt32(Console.ReadLine());
                student.AddGrade(input);
            }
        }
    }

}
