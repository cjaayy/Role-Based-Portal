using RoleBasedPortal.Models;

namespace RoleBasedPortal.Data
{
    public static class ApplicationData
    {
        public static List<User> Users { get; set; } = new List<User>
        {
            new User
            {
                Username = "admin",
                Password = "admin123",
                FullName = "Administrator",
                Role = "Admin"
            },
            new User
            {
                Username = "instructor1",
                Password = "inst123",
                FullName = "Juan Dela Cruz",
                Role = "Instructor",
                Degree = "Master",
                Department = "College of Computer Studies"
            },
            new User
            {
                Username = "instructor2",
                Password = "inst456",
                FullName = "Maria Santos",
                Role = "Instructor",
                Degree = "Doctor",
                Department = "College of Business Administration"
            },
            new User
            {
                Username = "student1",
                Password = "stud123",
                FullName = "Pedro Reyes",
                Role = "Student",
                Course = "BSIT",
                YearLevel = "3rd Year",
                Section = "A"
            },
            new User
            {
                Username = "student2",
                Password = "stud456",
                FullName = "Ana Garcia",
                Role = "Student",
                Course = "BSBA",
                YearLevel = "2nd Year",
                Section = "B"
            }
        };

        public static List<Instructor> Instructors { get; set; } = new List<Instructor>
        {
            new Instructor
            {
                Name = "Juan Dela Cruz",
                HighestDegree = "Master",
                Department = "College of Computer Studies"
            },
            new Instructor
            {
                Name = "Maria Santos",
                HighestDegree = "Doctor",
                Department = "College of Business Administration"
            }
        };

        public static List<Student> Students { get; set; } = new List<Student>
        {
            new Student
            {
                Name = "Pedro Reyes",
                Course = "BSIT",
                YearLevel = "3rd Year",
                Section = "A"
            },
            new Student
            {
                Name = "Ana Garcia",
                Course = "BSBA",
                YearLevel = "2nd Year",
                Section = "B"
            }
        };
    }
}
