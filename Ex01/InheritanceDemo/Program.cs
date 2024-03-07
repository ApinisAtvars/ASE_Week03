Student student = new Student("Atvars", "Apinis");
Console.WriteLine(student.FirstName);


Teacher teacher1 = new Teacher("Frederik", "W");
student.Study();
teacher1.Study();

CalculatorService s = new CalculatorService();
int a = 1;
int b = 1;

double aa = 1.5;
double bb = 1;
Console.WriteLine(s.Add(a, b));
Console.WriteLine(s.Add(aa, bb));