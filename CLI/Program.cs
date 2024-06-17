using Question2;

var c = new Circle(new System.Drawing.Point(0, 0), 3);
System.Console.WriteLine(c);
System.Console.WriteLine(c.Area);

var t = new Triangle(new System.Drawing.Point(0, 0), 4, 2, 3);
t.IsRight();
System.Console.WriteLine(t);
System.Console.WriteLine(t.Area);
