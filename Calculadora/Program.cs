Console.WriteLine("\n***** CALCULADORA *****");
Console.WriteLine("1 ---> Sumar\n2 ---> Restar\n3 ---> Multiplicar\n4 ---> Dividir\n5 ---> Elevar a la potencia\nSeleccione una opcion (1 - 5): ");
int option = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el primer numero: ");
double n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
double n2 = Convert.ToInt32(Console.ReadLine());
double result;
switch (option)
{
  case 1:
  result = n1 + n2;
  Console.WriteLine($"El resultado de la suma es: {result}");
  break;
  case 2:
  result = n1 - n2;
  Console.WriteLine($"El resultado de la resta es: {result}");
  break;
  case 3:
  result = n1 * n2;
  Console.WriteLine($"El resultado de la multiplicacion es: {result}");
  break;
  case 4:
  result = n1 / n2;
  Console.WriteLine($"El resultado de la division es: {result}");
  break;
  case 5:
  result = Math.Pow(n1, n2);
  Console.WriteLine($"El resultado del numero a su potencia es: {result}");
  break;
}
