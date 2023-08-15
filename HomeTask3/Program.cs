namespace HomeTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new("Niyazi", "Babayev", 24);
            Student student = new("Kamran", "Zeynalov", 19);
            teacher.Explain();
            student.Learn();
        }

    }
}