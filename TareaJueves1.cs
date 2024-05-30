Console.WriteLine("Escribe dos numeros en los cuales se hara una operacion a continuacion");

int NumeroUs1 = Convert.ToInt32(Console.ReadLine());
int NumeroUs2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe un numero para escoger tu operacion\n1.Suma\n2.Resta\n3.Multiplicacion\n4.Division");
int Eleccion = Convert.ToInt32(Console.ReadLine());

if (Eleccion <= 4) {
    if (Eleccion == 1)
    {
        Console.WriteLine("Sumando...\n" + (NumeroUs1 + NumeroUs2));
    }
    else if (Eleccion == 2) {
        Console.WriteLine("Restando...\n" + (NumeroUs1-NumeroUs2));
    }
    else if (Eleccion == 3) {
        Console.WriteLine("Multiplicando...\n" + (NumeroUs1 * NumeroUs2));
    }
    else
    {
        Console.WriteLine("Dividiendo...\n" + (NumeroUs1 / NumeroUs2));
    }
}
else {
    Console.WriteLine("Error");
}
