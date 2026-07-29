Console.Write("Enter the radius of the circle: ");
double radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Options:");
Console.WriteLine("A - Compute Area");
Console.WriteLine("P - Compute Perimeter");
Console.WriteLine("X - Exit");
Console.Write("Choose an option [A, P, X]: ");

char choice = char.ToUpper(Console.ReadKey().KeyChar); 
Console.WriteLine();

switch (choice)
{
    case 'A':
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area = {area}");
        break;
    case 'P':
        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine($"Perimeter = {perimeter}");
        break;
    case 'X':
        Console.WriteLine("Exit the application.");
        break;
    default:
        Console.WriteLine("Invalid selection.");
        break;
}
