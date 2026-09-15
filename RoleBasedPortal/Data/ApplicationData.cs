using RoleBasedPortal.Models;

namespace RoleBasedPortal.Data
{
    public class ApplicationData
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
                Password = "inst1",
                FullName = "Juan Dela Cruz",
                Role = "Instructor",
                Degree = "Masters=",
                Department = "College of Computer Studies"
            },

             new User
            {
                Username = "instructor2",
                Password = "inst1",
                FullName = "Maria Santos",
                Role = "Instructor",
                Degree = "Doctor",
                Department = "College of Business Administration"
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

        public static List<Student> Student { get; set; } = new List<Student>
        {

           

        };


    }
}
