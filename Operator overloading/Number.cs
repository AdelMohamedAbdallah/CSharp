namespace C__Course
{
    internal class Number
    {
        public Number(int num)
        {
            this.num = num;
        }

        public int num { get; set; }

        public static Number operator +(Number num1, Number num2)
        {
            var result = num1.num + num2.num;
            return new Number(result);
        }
    }
}
