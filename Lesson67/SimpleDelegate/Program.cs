using System;

namespace SimpleDelegate
{
    //A delegate to point to any methods with two input integers and return integer
    public delegate int BinaryOp(int x, int y);
    class SimpleMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Substract(int x, int y)
        {
            return x - y;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*********** Simple delegate example ***************");
            BinaryOp op = new BinaryOp(SimpleMath.Add);
            //Invoke add method indirectly using delegate
            Console.WriteLine("10 + 10 = {0}", op(10, 10));

            BinaryOp op1 = new BinaryOp(SimpleMath.Substract);
            Console.WriteLine("10 - 10 = {0}", op1(10, 10));
        }
    }
}
