// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Empecemos por definir una variable que sea capaz de generarnos un numero aleatorio
// Entre el 1 y el 20

Random VariableGeneradora = new Random();

// No confundir VariableGeneradora con la variable que GUARDA los datos de nuestra
// Pequeña funcion, por simplificacion y mostrar un flujo CLARO, las variables tendran
// nombres que destaquen su papel

int NumeroA2Divinar = VariableGeneradora.Next(1, 20);

// Si bien no es necesario poner 1, es buena practica hacerlo, ya que se le da el numero
// minimo a generar, en caso de que ocurran comportamientos no deseados, SIEMPRE es bueno
// pensar en los casos donde es posible que se comporte de manera inesperada

// Comando para escribir, si no sabes que es, solo revisa el ejemplo
// si de verdad no sabes que es, por favor revisa tus apuntes

// ... si no tienes apuntes, este comando sirve para mandar una linea a la consola, que sera
// mostrada al usuario, acepta diferentes caracteres pero no Markdown, en casos extraños
// puede romperse con caracteres no reconocidos, un consejo es que si quieres escribir en lineas
// separadas, NO uses varios comandos, solo usa \n para separar las lineas

// se pondra a ejemplo en este ejercicio

Console.WriteLine("Dime un numero entre el 1 y el 20\nSi dices un numero muy alto, se te dira\nLo mismo ocurrira si dices un numero muy bajo");

// Muchos tuvieron una complicacion al romper su loop, cosa que es muy sencilla
// Que has estado usando todo el tiempo? Variables. ¡Usa variables para romper el loop!
// Es de buena practica usar booleanos para los loops, ya que otras comprobaciones consumen poder de computacion

bool VerificadorCorrecto = true;

// Usa esta variable SIEMPRE en verdad/true para cuando QUIERAS mantener el loop, no para cuando quieras romperlo
// Ahora, agregare una variable extra para CONTAR los fallos, algo que se le pidio a los que fueron capaces de
// resolver la primera parte del ejercicio

int ContaFallas = 0;

// ¡Definir en 0, NO EN OTRO NUMERO, porque causara que el conteo este desfazado!
// ¡Si el usuario adivinara a la primera, esto causaria que aun asi cuente un error!

// Esto inicia nuestro loop
// VerificadorCorrecto ⬇ es la variable que se usa para mantener este loop ejecutandose
// VerificadorCorrecto esta en TRUE! Ya que le pusimos la condicional de que
// Si VerificadorCorrecto EQUIVALE A true el siguiente codigo se ejecutara
while (VerificadorCorrecto == true){

    // Linea que pide el input del usuario
    String NumeroEscrito = Console.ReadLine();
    // Usare Int32 en este caso, puedes usar un simple parse con int, pero esta es la manera que vimos en clases
    int NumeroTransformado = Int32.Parse(NumeroEscrito);

    // La verificacion del orden MENOR a MAYOR
    if (NumeroTransformado < NumeroA2Divinar){ //Menor
        Console.WriteLine("¡Tu numero necesita ser mas alto!");
        ContaFallas += 1; //Usamos nuestra variable para contar los fallos cuando este mensaje corre en la consola!
        }
    else if (NumeroTransformado > NumeroA2Divinar){ //Mayor
        Console.WriteLine("¡Tu numero necesita ser mas bajo!");
        ContaFallas += 1;//La variable en ejecucion de nuevo
    }
    else if (NumeroA2Divinar == NumeroTransformado){
        VerificadorCorrecto = false;//Esto ROMPE el loop, una vez el usuario ingresa la variable
        // ES IMPORTANTE ROMPER EL LOOP!! Si no, no importa que el jugador gane, estara atrapado respondiendo...
        if (ContaFallas != 0){//Si te da curiosidad, este codigo verifica que solo se corra el contador cuando falle
                              //Si no falla
                              //Pues no se ejecuta!
                              //Es simple
        Console.WriteLine("Muy buen trabajo, ese es el numero correcto\nHas Tenido exactamente... " + ContaFallas + " Falla/s!");
        }
    }
}

    
