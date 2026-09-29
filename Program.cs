Console.WriteLine("Inicio del Programa:");

 int numero, resultado;
            

Console.WriteLine("Ingrese un numero:\n");
numero = Convert.ToInt32(Console.ReadLine());

 for (int i = 1; i <= 10; i++)
 {
    resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
 }

 Console.WriteLine("\nFin del Programa");