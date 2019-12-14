using SQlibrary.interfaces;
using SQlibrary.models;

namespace SQlibrary.factory
{
    public class TriangleFactory : iFigureFactory
    {
        iIOmethod ioMethod;
        public TriangleFactory(iIOmethod method)
        {
            ioMethod = method;
        }

        public iFigure create()
        {
            if (ioMethod == null)
                return null;

            int a, b, c;

            do
            {
                a = b = c = 0;
                ioMethod.showData("Please input the triangle with correct sides!");
                ioMethod.showData("Side A (example, 3):");
                a = ioMethod.getIntData();
                ioMethod.showData("Side B (example, 4)");
                b = ioMethod.getIntData();
                ioMethod.showData("Side C (example, 5):");
                c = ioMethod.getIntData();
                // будем получать данные о стороных до победного конца. Нужен выход?
                // 3 4 5 - прямоугольный
                // 3 7 10 - нет
            }
            while (!isTriangleOK(a, b, c));

            return new Triangle(a, b, c);
        }

        public bool isTriangleOK(int a, int b, int c)
        {
            if ((a > b + c) || (b > a + c) || (c > a + b))
                return false;
            return true;
        }
    }
}
