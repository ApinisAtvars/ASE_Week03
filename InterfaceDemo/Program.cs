Circle circle = new Circle(100);
Circle circle2 = new Circle(20);
Circle circle3 = new Circle(50);
Rectangle rectangle = new Rectangle(10, 20);
Rectangle rectangle2 = new Rectangle(25, 30);


List<IShape> list = new List<IShape>();
list.Add(circle);
list.Add(circle2);
list.Add(circle3);
list.Add(rectangle);
list.Add(rectangle2);

foreach (IShape shape in list)
{
    shape.Display();
}
