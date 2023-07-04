
int CalcularCuadrado(int n) {
    Console.WriteLine(n * n);
    return n * n;
}

//CalcularCuadrado(2);

void calcularAprobado(int a) {
    if (a < 5)
    {
        Console.WriteLine("Reprobado");
    }
    else if (a == 5)
    {
        Console.WriteLine("Falta un punto para aprobar");
    }
    else {
        Console.WriteLine("Haz aprobado");
    }
}

calcularAprobado(1);
calcularAprobado(5);
calcularAprobado(9);
