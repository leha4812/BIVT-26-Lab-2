using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;
            // code here
            for (int i = 0; i <= n; ++i)
                answer += Math.Sin(i * x) / Math.Pow(x, i - 1);
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            int fact = 1;
            for (int i = 1; i <= n; ++i, fact *= i)
                answer += Math.Pow(-1, n) * (Math.Pow(5, n) /);
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}
