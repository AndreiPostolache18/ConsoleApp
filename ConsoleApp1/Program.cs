


using HomeworkDB1;

namespace HomeworkDB1
{
    public class Program
    {
        public static void Main()
        {
            using (CodeFirstContext context = new CodeFirstContext())
            {
                var stud = new Student() { FirstName = "Andrei", SurName = "Postolache" };
                if (stud != null)
                
                        context.Students.Add(stud);
                context.SaveChanges();
                Console.WriteLine("Student Added");
                Console.ReadKey();
            }

        }
    }
}




