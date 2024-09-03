namespace C__Course.Threading
{
    internal class Wallet
    {
        private readonly object _locker = new object();
        public Wallet(string? name, int bitcoin, string password)
        {
            this.name = name;
            this.bitcoin = bitcoin;
            this.password = password;
        }

        private string name { get; set; }
        private int bitcoin { get; set; }
        private string password { get; set; }

        public void Debit(int amount)
        {
            Thread.Sleep(1000);
            int value = Math.Abs(amount);
            bitcoin -= value;
        }
        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            int value = Math.Abs(amount);
            bitcoin += value;
        }

        public void RunProcess()
        {
            lock (_locker)
            {
                Monitor.TryEnter(_locker, 1000);
                int[] amount = { 10, -40, 34, -87, 19, 40, -10, 24, 50 }; // 40
                foreach (var item in amount)
                {
                    if (item < 0)
                    {
                        Debit(item);
                    }
                    else
                    {
                        Credit(item);
                    }
                    Console.WriteLine($"[Thread name : {Thread.CurrentThread.Name}\tThreadId : {Thread.CurrentThread.ManagedThreadId}\t" +
                    $"ProcessorId : {Thread.GetCurrentProcessorId()}]\n");
                }
                Monitor.Exit(_locker);
            }
        }

        public override string ToString()
        {
            return $"Name : {name}\nThe balance : {bitcoin}$ \nTime : {DateTime.Now.ToLongTimeString()}\n";
        }

    }
}
