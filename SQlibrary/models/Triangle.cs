using SQlibrary.interfaces;
using System;

namespace SQlibrary.models
{
    public class Triangle : iFigure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public float getSquare()
        {
            float halfP = (A + B + C) / 2;
            float sq = halfP * (halfP - A) * (halfP - B) * (halfP - C);
            if (sq > 0)
                return (float)Math.Sqrt(sq);
            return 0;
        }

        public bool isRightAngle()
        {
            int[] longest = { A, B, C };
            for (int i = 1; i < 3; i++)
            {
                if (longest[i] > longest[0])
                {
                    int b = longest[0];
                    longest[0] = longest[i];
                    longest[i] = b;
                }
            }
            if (longest[0] == 0)
                return false;

            return ((longest[0] * longest[0]) == (longest[1] * longest[1] + longest[2] * longest[2]));
        }
    }
}
