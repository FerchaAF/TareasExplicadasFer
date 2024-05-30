Console.WriteLine("Escribe cuatro numeros en los cuales se hara una operacion a continuacion");

int NumeroUs1 = Convert.ToInt32(Console.ReadLine());
int NumeroUs2 = Convert.ToInt32(Console.ReadLine());
int NumeroUs3 = Convert.ToInt32(Console.ReadLine());
int NumeroUs4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("A continuacion se ordenaran");

var arrraro = new[] {NumeroUs1, NumeroUs2, NumeroUs3, NumeroUs4};
/*
Array.Sort(arrraro new Comparison<int>((x,y) => y.CompareTo(x)));
*/
Array.Sort(arrraro);
Console.WriteLine("{0} {1} {2} {3}", arrraro[0], arrraro[1], arrraro[2], arrraro[3]);

/*
if (NumeroUs1 < NumeroUs2 | NumeroUs1 < NumeroUs2 | NumeroUs1 < NumeroUs3 | NumeroUs1 < NumeroUs4)
{

}
*/

