/*
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
*/

//Metodos


var moto = new Motos();

//Motos.Arrancar();
moto.ArrancarMoto();

//Extension
Funciones.ExtensionMotos.Acelerar();


//Retorno de Metodos
var gasolina = moto.CantidadGasolina();
Console.WriteLine($"Cantida de gasolina {gasolina} litros de combustible");

//SobreCargas
int nivelDeposito = moto.EcharGasolina(10);
Console.WriteLine($"Ahora tenemos {nivelDeposito} listros de combustible");

class Motos {
    public static void Arrancar() {
        Console.WriteLine("Arranca");
    }

    public void ArrancarMoto() {
        Console.WriteLine("Arranca esta moto");
     }

    public int CantidadGasolina() {

        //se ejecuta codigo
        int gasolina = 20; //litros

        return gasolina;
    }

    public int EcharGasolina(int litros) {

        int nivelDeposito = 20 + litros;
        return nivelDeposito;
    }
}