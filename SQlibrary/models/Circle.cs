using SQlibrary.interfaces;

namespace SQlibrary.models
{
    public class Circle : iFigure
    {
        public int Radius { get; set; }

        public Circle(int r)
        {
            Radius = r;
        }

        public float getSquare()
        {
            return 3.14f * Radius * Radius;
        }
    }
}
