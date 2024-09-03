namespace C__Course.LinkedList
{
    internal class Customer : IComparable<Customer>
    {
        public Customer(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        private string name { get; set; }
        private int id { get; set; }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + id.GetHashCode();
            return hash;
        }
        public override bool Equals(object? obj)
        {
            var customer = obj as Customer;
            if (customer == null)
                return false;
            return this.name.Equals(customer.name, StringComparison.OrdinalIgnoreCase) && this.id.Equals(customer.id);
        }
        public override string ToString()
        {
            return $"{this.name}\t{this.id}";
        }

        public int CompareTo(Customer? other)
        {
            if (other == null)
                return 1;
            if (other == this)
                return 0;
            return this.name.CompareTo(other.name);
        }
    }
}
