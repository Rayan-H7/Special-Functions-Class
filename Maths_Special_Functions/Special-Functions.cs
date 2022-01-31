using System;
using System.Collections.Generic;
using System.Text;
using Maths;

namespace Maths_Special_Functions{
    class SpEq
    {
        public cubed(int x)
        {
            cubed_total = x * x * x;
            Console.WriteLine(cubed_total);
        }
        public sqroot(int x)
        {
            sqroot_total = Math.Sqrt(x);
            Console.WriteLine(sqroot_total);
            return sqroot_total;
        }
        public pythag(int a, int b)
        {
            int a_sq = a * a;
            int b_sq = b * b;
            int sq_total = a_sq + b_sq;
            int c = Math.Sqrt(sq_total);
            Console.WriteLine(c);
            return c;
        }
        public gradient(int x1, int y1, int x2, int y2)
        {
            int change_y = y2 - y1;
            int change_x = x2 - x1;
            int grad_total = change_y / change_x;
            Console.WriteLine(grad_total);
            return grad_total;
        }
        public reciprocal(float n)
        {
            float recip_total = 1 / n;
            Console.WriteLine(recip_total);
            return recip_total;
        }
        public negative_reciprocal(float n)
        {
            float neg_recip_total = -1 / n;
            Console.WriteLine(neg_recip_total);
            return neg_recip_total;
        }
 
    }
}