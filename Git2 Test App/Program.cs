using System;

namespace Git2_Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Git2 Test App v0.0.00.001");

            Console.WriteLine("master .07");

            Console.WriteLine(new FeatureA().Version);
            Console.WriteLine(new FeatureB().Version);
            Console.WriteLine(new FeatureC().Version);

            Console.Read();
        }
    }
}
