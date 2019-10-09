using System;

namespace _5._4__泛型接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IIndex<Rectangle> rectangle = RectangleCollection.GetRectangle();
            IIndex<Shape> shape = rectangle;
            for(int i=0;i<shape.Count;i++)
            {
                Console.WriteLine(shape[i]);
            }
            IDsplay<Shape> shapeDisplay = new ShapeDisplay();
            IDsplay<Rectangle> rectangleDisplay = shapeDisplay;
            rectangleDisplay.Show(rectangle[0]);

        }
    }
}
