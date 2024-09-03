namespace C__Course.LinkedList
{
    internal class Hashset
    {
        public Hashset(string name, int id, int levle)
        {
            this.name = name;
            this.id = id;
            this.levle = levle;
        }

        private string name { get; set; }
        private int id { get; set; }
        private int levle { get; set; }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = (hash * 23) + id.GetHashCode();
            return hash;
        }
        public override bool Equals(object? obj)
        {
            var hashset = obj as Hashset;
            if (hashset == null)
            {
                return false;
            }
            else
            {
                return hashset.name.Equals(name) &&
                hashset.id.Equals(id) &&
                hashset.levle.Equals(levle);
            }
        }

        public override string ToString()
        {
            return $"{name}\t{id}\t{levle}";
        }

    }
}
