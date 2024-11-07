using System;

namespace SimpleMath
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SimpleMath m = new SimpleMath();
            m.SetMathHandler(
                (msg, result) => {
                    Console.WriteLine("Message: {0}, Result: {1}", msg, result);
                }
            );
            m.Add(10, 10);
            Console.ReadLine();
        }
    }
}
