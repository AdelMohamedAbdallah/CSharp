
namespace C__Course.ListandDictionary
{
    internal class Student
    {
        public int id { get; set; }
        public string? name { get; set; }

        public override bool Equals(object? obj)
        {
            var student = obj as Student;
            if (student is null)
                return false;
            return this.name!.Equals(student.name, StringComparison.OrdinalIgnoreCase) &&
                this.id.ToString().Equals(student.id.ToString(), StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = (hash * 11) + name!.GetHashCode();
            hash = (hash * 11) + id.GetHashCode();
            return hash;
        }

        public void Print(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Name :{student.name}\t Id : {student.id}\n");
            }
            Console.WriteLine($"Capacity : {students.Capacity}");
            Console.WriteLine($"Count : {students.Count}");
        }
    }
}
