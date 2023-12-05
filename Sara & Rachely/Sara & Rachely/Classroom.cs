namespace Sara___Rachely
{
    public class Classroom
    {

       public static List<string> students { get;set; }
        
        //public Classroom()
        //{
        //    students = new List<string>();
        //}

        //public void AddStudent(string name)
        //{
        //    students.Add(name);
        //}
        static Classroom()
        {
            students = new List<string>

            {
                 { "Sara" },
                 { "Rachely"}
            };
        }
    }
}
