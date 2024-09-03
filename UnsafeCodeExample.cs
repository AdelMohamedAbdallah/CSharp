namespace C__Course
{
    public class UnsafeCodeExample
    {
        public unsafe void UsePointer()
        {
            int var = 20;
            int* p = &var;

            Console.WriteLine("Value of var: {0}", var);
            Console.WriteLine("Value of *p: {0}", *p);

            *p = 30;

            Console.WriteLine("New value of var: {0}", var);
            Console.WriteLine("New value of *p: {0}", *p);
        }
    }

}
