// Practical 1: Student Management System
// Objective: Demonstrate Single Responsibility Principle (SRP)
// Break down student handling into 3 separate classes based on their responsibility.

using System;

namespace SolidAssignments.Practical1
{
    // 1. Student Model - Holds only student data
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Student(int id, string name, string email)
        {
            StudentId = id;
            Name = name;
            Email = email;
        }
    }

    // 2. Database Class - Handles only DB operations
    public class StudentDbOperations
    {
        public void SaveStudentToDb(Student student)
        {
            Console.WriteLine("[Database] Saving student record for " + student.Name + " (ID: " + student.StudentId + ")...");
        }
    }

    // 3. Email Service Class - Handles sending notifications
    public class StudentEmailNotifier
    {
        public void SendWelcomeEmail(Student student)
        {
            Console.WriteLine("[Email Service] Welcome email sent successfully to " + student.Email);
        }
    }
}