using FQS_Quartic;
using One_Seven_Two_Eight_Quartic;
using System.Diagnostics;
using System.Numerics;

namespace Quartic
{
    class Program
    {
        public static int repetitions = 1000000;
        public static double first_coefficient = 1;
        public static double second_coefficient = 2;
        public static double third_coefficient = 3;
        public static double fourth_coefficient = 4;
        public static double fifth_coefficient = 5;

        static void Main()
        {

            Profile("FQS Quartic", repetitions, Tester_FQS_Quartic);

            Profile("FQS Cubic", repetitions, Tester_FQS_Cubic);

            Profile("FQS Quadratic", repetitions, Tester_FQS_Quadratic);

            Profile("One_Seven_Two_Eight Quartic", repetitions, Tester_One_Seven_Two_Eight_Quartic);

            Profile("One_Seven_Two_Eight Cubic", repetitions, Tester_One_Seven_Two_Eight_Cubic);
        }

        static void Tester_FQS_Quartic()
        {
            FQS_Quartic_Calcs.Quartic(first_coefficient, second_coefficient, third_coefficient, fourth_coefficient, fifth_coefficient);
        }
        static void Tester_FQS_Cubic()
        {
            FQS_Quartic_Calcs.Cubic(first_coefficient, second_coefficient, third_coefficient, fourth_coefficient);
        }
        static void Tester_FQS_Quadratic()
        {
            FQS_Quartic_Calcs.Quadratic(first_coefficient, second_coefficient, third_coefficient);
        }

        static void Tester_One_Seven_Two_Eight_Quartic()
        {
            One_Seven_Two_Eight_Quartic_Calcs.Quartic(first_coefficient, second_coefficient, third_coefficient, fourth_coefficient, fifth_coefficient);
        }
        static void Tester_One_Seven_Two_Eight_Cubic()
        {
            One_Seven_Two_Eight_Quartic_Calcs.Cubic(first_coefficient, second_coefficient, third_coefficient, fourth_coefficient);
        }

        static double Profile(string description, int iterations, Action func)
        {
            //Run at highest priority to minimize fluctuations caused by other processes/threads
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Thread.CurrentThread.Priority = ThreadPriority.Highest;

            // warm up 
            func();

            var watch = new Stopwatch();

            // clean up
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            watch.Start();
            for (int i = 0; i < iterations; i++)
            {
                func();
            }
            watch.Stop();
            Console.WriteLine(description + ":");
            Console.WriteLine(" Time Elapsed {0} ms for {1} repetitions", watch.Elapsed.TotalMilliseconds, repetitions);
            Console.WriteLine(" Time Elapsed {0} μs on average per repetition", (watch.Elapsed.TotalMilliseconds * 1000) / (double)repetitions); 
            return watch.Elapsed.TotalMilliseconds;
        }
    }
}