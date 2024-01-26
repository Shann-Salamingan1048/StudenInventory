using System;
using System.Collections.Generic;
using System.Threading;


namespace StudenInventory
{
    class StudentInventory
    {
        static List<Student> students_infos = new List<Student>();
        public StudentInventory(){ }
        public void Run()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Student Inventory\n1. Add\n2. View Student\n3. Remove Student\n4. Search Strudent\n5. Exit");
                string chosenStr = Console.ReadLine();
                if (UInt16.TryParse(chosenStr, out UInt16 chosen))
                {
                    Console.Clear();
                    switch (chosen)
                    {
                        case 1:
                            AddStudent();
                            break;
                        case 2:
                            ViewStudent();
                            break;
                        case 3:
                            RemoveStudent();
                            break;
                        case 4:
                            SearchStudent();
                            break;
                        case 5:
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("\nInvalid choice. Please choose 1 or 2.");
                            Console.Write("Press any key to exit. ");
                            Console.ReadKey();
                            break;
                    }
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nInvalid input. Please enter a valid number (1 or 2).");
                    Console.Write("Press any key to exit. ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        private void AddStudent()
        {
            Student student = new Student();
            Console.Write("Enter Student ID: ");
            student.StudentID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            student.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Address: ");
            student.Address = Console.ReadLine();

            Console.Write("Enter Student Section and Course: ");
            student.Section_Course = Console.ReadLine();

            Console.WriteLine("Please wait.....");
            Thread.Sleep(1000);
            Console.WriteLine("Succesfully added!");
            students_infos.Add(student);
            Console.Write("Press to continue. ");
            Console.ReadKey();
        }
        private void ViewStudent()
        {
            if (students_infos.Count == 0)
            {
                Console.WriteLine("No Student Information Yet!");
            }
            else
            {
                UInt16 studentCount = 1;
                foreach (var student in students_infos)
                {
                    Console.WriteLine("Student {0}: ", studentCount);
                    Console.WriteLine("Student ID: {0}", student.StudentID);
                    Console.WriteLine("Student Name: {0}", student.Name);
                    Console.WriteLine("Student Age: {0}", student.Age);
                    Console.WriteLine("Student Address: {0}", student.Address);
                    Console.WriteLine("Student Section and Course: {0}", student.Section_Course);
                    Console.WriteLine();
                    studentCount++;
                }
            }
            Console.Write("Press to continue. ");
            Console.ReadKey();
        }
        private void RemoveStudent()
        {
            if (students_infos.Count != 0)
            {
                Console.Write("Enter Student ID to remove: ");
                int searchID = Convert.ToInt32(Console.ReadLine());

                Student foundStudent = students_infos.Find(s => s.StudentID == searchID); // Lambda Expression
                if (foundStudent != null)
                {
                    Console.WriteLine("Student found!");
                    Console.WriteLine();
                    Console.WriteLine("Student Information:");
                    Console.WriteLine("Student ID: {0}", foundStudent.StudentID);
                    Console.WriteLine("Student Name: {0}", foundStudent.Name);
                    Console.WriteLine("Student Age: {0}", foundStudent.Age);
                    Console.WriteLine("Student Address: {0}", foundStudent.Address);
                    Console.WriteLine("Student Section and Course: {0}", foundStudent.Section_Course);

                    Console.WriteLine();

                    Console.Write("Press to continue. ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Removing.....");

                    Thread.Sleep(1000);
                    Console.Clear();

                    students_infos.Remove(foundStudent);
                    Console.WriteLine("Successfully Removed!");
                }
                else
                {
                    Console.WriteLine("Student not found.\n");
                }
            }
            else
            {
                Console.WriteLine("No Student Information Yet!");
            }
            Console.Write("Press to continue. ");
            Console.ReadKey();
        }
        private void SearchStudent()
        {
            if (students_infos.Count != 0)
            {
                Console.Write("Enter Student ID to search: ");
                int searchID = Convert.ToInt32(Console.ReadLine());

                Student foundStudent = students_infos.Find(s => s.StudentID == searchID); // Lambda Expression

                if (foundStudent != null)
                {
                    Console.WriteLine("Student found!");
                    Console.WriteLine();
                    Console.WriteLine("Student Information:");
                    Console.WriteLine("Student ID: {0}", foundStudent.StudentID);
                    Console.WriteLine("Student Name: {0}", foundStudent.Name);
                    Console.WriteLine("Student Age: {0}", foundStudent.Age);
                    Console.WriteLine("Student Address: {0}", foundStudent.Address);
                    Console.WriteLine("Student Section and Course: {0}", foundStudent.Section_Course);
                }
                else
                {
                    Console.WriteLine("Student not found.\n");
                }
            }
            else
            {
                Console.WriteLine("No Student Information Yet!");
            }
            Console.Write("Press to continue. ");
            Console.ReadKey();
        }
    }
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Section_Course { get; set; }

    }
}
