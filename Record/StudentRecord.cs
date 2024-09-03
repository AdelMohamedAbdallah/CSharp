
namespace C__Course.Record
{
    #region ConstructorToRecivedata
    public partial class StudentRecord
    {
        public StudentRecord(string fname, string lname, int id, int level)
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
            this.level = level;
        }
    }
    #endregion
    public partial class StudentRecord
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public int id { get; set; }
        public int level { get; set; }
    }
    public partial class StudentRecord
    {
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return obj is StudentRecord record &&
                   fname == record.fname &&
                   lname == record.lname &&
                   id == record.id &&
                   level == record.level;
        }
    }
    public partial class StudentRecord
    {
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + fname.GetHashCode();
            hash = hash * 23 + lname.GetHashCode();
            hash = hash * 23 + id.GetHashCode();
            hash = hash * 23 + level.GetHashCode();

            return hash;
        }
    }
    public partial class StudentRecord
    {
        public override string ToString()
        {
            return $"{{FName : {fname}\tLname : {fname}\tid : {id}\tlevel : {level}}}";
        }
    }

    public partial class StudentRecord
    {
        public static bool operator ==(StudentRecord st1, StudentRecord st2)
        {
            if (st1 is null)
            {
                if (st1 is null)
                {
                    return true;
                }
                return false;
            }
            return st1.Equals(st2);
        }
    }
    public partial class StudentRecord
    {
        public static bool operator !=(StudentRecord st1, StudentRecord st2)
        {
            return !(st1 == st2);
        }
    }



}
