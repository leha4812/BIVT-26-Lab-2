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
            double power = 1.0;
            for (int i = 1; i <= n; ++i){
                answer += Math.Sin(i * x) / power;
                power *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double power = 5.0;
            for (double i = 1.0, fact = 1.0; i <= n; ++i){
                fact *= i;
                if (i % 2 != 0)
                    answer -= power / fact;
                else
                    answer += power / fact;
                power *= 5;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            int a = 0, b = 1, next = 0;

            for (int i = 0; i < n; ++i)
            {
                next = a + b;
                answer += a;
                a = b;
                b = next;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            for (int s = 0, i = 0; s <= L; ++i){
                s += a + i * h;
                if (s <= L)
                    answer += 1;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;
            for (; elem > 0.0001;)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;

            }


            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            for (; S < L;answer += h)
                S *= 2;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            a += S;
            for (int n = 1; n <= 7; ++n)
            {
                a *= 1 + (I / 100);
                S += a;
            }
            double d = 0;
            d += S;


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
