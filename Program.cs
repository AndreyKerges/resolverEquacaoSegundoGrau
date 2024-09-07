double a, b, c;

Console.WriteLine("--- Equação de Segundo Grau ---");

Console.WriteLine("Digite o coeficiente a: ");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o coeficiente b: ");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o coeficiente c: ");
c = Convert.ToDouble(Console.ReadLine());

double delta = b * b - 4 * a * c;

Console.WriteLine($"Delta (Δ): {delta}");

if (delta > 0)
{
    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.Write($"A equação possuí duas raízes distintas: ");
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write($"x1 = {x1} e x2 = {x2}");
    Console.ResetColor();
}
else if (delta == 0)
{
    double x = -b / (2 * a);
    Console.Write($"A equação possuí uma raíz real ou duas raízes iguais: ");
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write($"x = {x}");
    Console.ResetColor();

}
else
{
    double realPart = -b / (2 * a);
    double imaginaryPart = Math.Sqrt(-delta) / (2 * a);
    Console.WriteLine($"A equação não possui raízes reais. As raízes complexas são:");
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine($"x1 = {realPart} + {imaginaryPart}i");
    Console.WriteLine($"x2 = {realPart} + {imaginaryPart}i");
    Console.ResetColor();
}

