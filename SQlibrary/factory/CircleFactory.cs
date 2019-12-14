using SQlibrary.interfaces;
using SQlibrary.models;

namespace SQlibrary.factory
{
    public class CircleFactory : iFigureFactory
    {
        iIOmethod ioMethod;
        public CircleFactory(iIOmethod method)
        {
            ioMethod = method;
        }

        public iFigure create()
        {
            if (ioMethod == null)
                return null;

            ioMethod.showData("Please input the radius:");
            int r = ioMethod.getIntData();

            return new Circle(r);
        }
    }
}
