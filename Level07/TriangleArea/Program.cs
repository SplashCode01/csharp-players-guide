Console.WriteLine("Welcome, Triangle Farmer!");
Console.WriteLine("I see you need some help calculating your triangle area.");
Console.WriteLine("Worry not! Input your base size and height below, and let me do the rest:");
double triangleBase = Convert.ToDouble(Console.ReadLine());
double triangleHeight = Convert.ToDouble(Console.ReadLine());

double area = (triangleBase * triangleHeight) / 2;

Console.WriteLine($"The area of your triangle is: {area}.");
Console.ReadKey();