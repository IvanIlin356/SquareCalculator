namespace SQlibrary.interfaces
{
    public interface iFigureFactory // все фабрики, производящие фигуры, должны наследоваться от этого
    {
        iFigure create();
    }
}
