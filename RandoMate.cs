// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool Loopy = true;
int PuntosInutiles = 0;

while (Loopy)
{

    Console.WriteLine("Generando...\nPor favor espera");

    Random VariableGeneradora = new Random();

    int SeleccionEjercicio = VariableGeneradora.Next(1, 4);

    int NumeroUs1 = VariableGeneradora.Next(1, 100);
    int NumeroUs2 = VariableGeneradora.Next(1, 100);
    // int NumeroUs3 = VariableGeneradora.Next(1, 100);
    // int NumeroUs4 = VariableGeneradora.Next(1, 100);

    if (SeleccionEjercicio <= 4)
    {
        if (SeleccionEjercicio == 1)
        {
            Console.WriteLine("Sumando...\n" + NumeroUs1 + "+" + NumeroUs2 + "\n");
            int RespuestaSuma = NumeroUs1 + NumeroUs2;
            Console.WriteLine("¿Cual es la respuesta correcta?");
            int RespuestaUsuario = Convert.ToInt32(Console.ReadLine());
            if (RespuestaUsuario == RespuestaSuma)
            {
                Console.WriteLine("¡Felicitaciones!\n+1 Punto inutil");
                PuntosInutiles += 1;
            }
            else
            {
                Console.WriteLine("Horrible, rompiendo el loop\n-9000 Puntos inutiles");
                Loopy = false;
            }
        }
        else if (SeleccionEjercicio == 2)
        {
            Console.WriteLine("Restando...\n" + NumeroUs1 + "-" + NumeroUs2 + "\n");
            int RespuestaSuma = NumeroUs1 - NumeroUs2;
            Console.WriteLine("¿Cual es la respuesta correcta?");
            int RespuestaUsuario = Convert.ToInt32(Console.ReadLine());
            if (RespuestaUsuario == RespuestaSuma)
            {
                Console.WriteLine("¡Felicitaciones!\n+1 Punto inutil");
                PuntosInutiles += 1;
            }
            else
            {
                Console.WriteLine("Horrible, rompiendo el loop\n-9000 Puntos inutiles");
                Loopy = false;
            }
        }
        else if (SeleccionEjercicio == 3)
        {
            Console.WriteLine("Multiplicando...\n" + NumeroUs1 + "*" + NumeroUs2 + "\n");
            int RespuestaSuma = NumeroUs1 * NumeroUs2;
            Console.WriteLine("¿Cual es la respuesta correcta?");
            int RespuestaUsuario = Convert.ToInt32(Console.ReadLine());
            if (RespuestaUsuario == RespuestaSuma)
            {
                Console.WriteLine("¡Felicitaciones!\n+1 Punto inutil");
                PuntosInutiles += 1;
            }
            else
            {
                Console.WriteLine("Horrible, rompiendo el loop\n-9000 Puntos inutiles");
                Loopy = false;
            }
        }
        else
        {
            float NumeroDiv1 = NumeroUs1;
            float NumeroDiv2 = NumeroUs2;
            Console.WriteLine("Dividiendo...\n" + NumeroUs1 + "/" + NumeroUs2 + "\n");
            float RespuestaSuma = NumeroDiv1 / NumeroDiv2;
            Console.WriteLine((NumeroDiv1 / NumeroDiv2));
            Console.WriteLine("¿Cual es la respuesta correcta?");
            float RespuestaUsuario = float.Parse(Console.ReadLine());
            if (RespuestaUsuario == RespuestaSuma)
            {
                Console.WriteLine("¡Felicitaciones!\n+1 Punto inutil");
                PuntosInutiles += 1;
            }
            else
            {
                Console.WriteLine("Horrible, rompiendo el loop\n-9000 Puntos inutiles");
                Loopy = false;
            }
        }
    }
    else
    {
        Console.WriteLine("Error");
    }
}
Console.WriteLine("\nBien tus puntos inutiles totales son...!\n" + PuntosInutiles);
