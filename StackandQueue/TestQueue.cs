namespace C__Course.StackandQueue
{
    internal class TestQueue
    {
        public TestQueue(string name, int id, int level)
        {
            this.name = name;
            this.id = id;
            this.level = level;
        }

        private string name { get; set; }
        private int id { get; set; }
        private int level { get; set; }

        public override string ToString()
        {
            return $"Name : {name}\t\tId : {id}\t\tLevel : {level}";
        }

    }
}
