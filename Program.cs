// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int age = 20;     

if (verificarSiEsMayorDeEdad(age))
{
    Console.WriteLine("Puede entrar");
}

bool verificarSiEsMayorDeEdad(int age)
{
    return age > 18;
}

