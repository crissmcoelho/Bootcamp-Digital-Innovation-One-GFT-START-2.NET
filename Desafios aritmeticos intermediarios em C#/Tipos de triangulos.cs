using System;

using System.Collections;

class Desafio {

 public static void Main()

 {

string[] s = Console.ReadLine().Split(' ');

Array.Sort(s);

Array.Reverse(s);



double a = double.Parse(s[0]);

double b = double.Parse(s[1]);

double c = double.Parse(s[2]);

double a2 = Math.Pow(a, 2.0);

double b2 = Math.Pow(b, 2.0);

double c2 = Math.Pow(c, 2.0);

//continue a solucao

if (a >= (b + c))

{

Console.WriteLine("NAO FORMA TRIANGULO");

}

else if ( a2 == ( b2 + c2) )

{

Console.WriteLine("TRIANGULO RETANGULO");

}

else if ( a2 > ( b2 + c2 ) )

{

Console.WriteLine("TRIANGULO OBTUSANGULO");

}

else if ( a2 < ( b2 + c2 ) )

{

Console.WriteLine("TRIANGULO ACUTANGULO");

}

if ( (a == b ) && ( b == c ) )

{

Console.WriteLine("TRIANGULO EQUILATERO");

}

else if ( ( ( a == b ) && ( a != c ) ) || ( ( b == c ) && ( b != a) ) || ( (c == a ) && (c!= b) ) )

{

Console.WriteLine("TRIANGULO ISOSCELES");

}

Console.ReadLine();

 }

}
