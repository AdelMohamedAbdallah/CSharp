namespace C__Course.Record
{
    public record StudentRecordTest
    {
        public StudentRecordTest(string fname, string lname, int id, int level)
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
            this.level = level;
        }

        public string fname { get; init; }
        public string lname { get; init; }
        public int id { get; init; }
        public int level { get; init; }
    }
}
