using Generics.Src;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("=== Part 03 ===");

            
            var studentStore = new Store<Student>();
            studentStore.Add(new Student { Id = 1, Name = "marwan" });
            studentStore.Add(new Student { Id = 2, Name = "maged" });
            studentStore.Add(new Student { Id = 3, Name = "ali" });
            studentStore.Add(new Student { Id = 4, Name = "mohamed" });
            studentStore.Add(new Student { Id = 5, Name = "youssef" });

            var courseStore = new Store<Course>();
            courseStore.Add(new Course { Id = 101, Title = "C# Programming", Price = 100m });
            courseStore.Add(new Course { Id = 102, Title = "Design Patterns", Price = 150m });
            courseStore.Add(new Course { Id = 103, Title = "oop", Price = 120m });

            
            var student = studentStore.GetById(2);
            var course = courseStore.GetById(102);
            Console.WriteLine($"Found Student: {student?.Name}");
            Console.WriteLine($"Found Course: {course?.Title}");

            
            try
            {
                studentStore.Add(new Student { Id = 1, Name = "Duplicate Student" });
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Caught expected exception: {ex.Message}");
            }

            
            Console.WriteLine("\nPage 2 of Students (Size 2):");
            foreach (var s in studentStore.GetAll().Page(2, 2))
            {
                Console.WriteLine($" - ID: {s.Id}, Name: {s.Name}");
            }

            
            var courseList = new List<Course>
{
    new Course { Id = 201, Title = "SQL Basics", Price = 80m },
    new Course { Id = 202, Title = "Web API", Price = 110m }
};
            var foundInList = courseList.FindById(202);
            Console.WriteLine($"\nFound in Plain List via FindById: {foundInList?.Title}");

            // Leave commented out as required by Step 7:
            // Store<string> stringStore = new Store<string>(); // must NOT compile
        }
    }
}
