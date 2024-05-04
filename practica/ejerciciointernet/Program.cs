
// 1


// decimal dolar(decimal dinero)
// {
// 	decimal re = dinero * 0.0011M;

// 	return re;
// }
// decimal soles(decimal dinero)
// {
// 	dinero = dinero * 0.0043M;
// 	return dinero;
// }
// decimal bolivianos(decimal dinero)
// {
// 	dinero = dinero * 0.0079M;
// 	return dinero;
// }
// decimal euros(decimal dinero)
// {
// 	dinero = dinero * 0.0011M;
// 	return dinero;	
// }
// decimal libra(decimal dinero)
// {
// 	dinero = dinero * 0.00091M;
// 	return dinero;
// }

// void calcular(){

// 	Console.WriteLine("Ingrese la cantidad de dinero en pesos: " );
// 	decimal costo = Convert.ToDecimal(Console.ReadLine());
// 	Console.WriteLine("Escribe el nombre de la moneda ala que quiere cambia de pesos: ");
// 	string moneda = Console.ReadLine();
// 	decimal total = 0;
// 	switch (moneda)
// 	{
// 		case  "dolar":
// 			total = dolar(costo);
// 			Console.WriteLine("Este es la conversion: " + total);
// 				break;	
// 		case  "soles":
// 			total = soles(costo);
// 			Console.WriteLine("Este es la conversion: " + total);
// 		break;
// 		case  "bolivianos":
// 			total = bolivianos(costo);
// 			Console.WriteLine("Este es la conversion: " + total);
// 			break;
// 		case  "euros":
// 			total = euros(costo);
// 			Console.WriteLine("Este es la conversion: " + total);
// 			break;
// 		case  "libra":
// 			total = libra(costo);
// 			Console.WriteLine("Este es la conversion: " + total);
// 			break;

// 	}

// }
// calcular();
// 2.- Crear un método que permita calcular el área de un rectángulo.

// decimal Calculararea(decimal based , decimal altura)
// {
// 	decimal total = 0.5M * (based * altura);
// 	return total;
// }

// void proceso()
// {
// 	Console.WriteLine("Escribe la base del triangulo: ");
// 	decimal basede = Convert.ToDecimal(Console.ReadLine());	
// 	Console.WriteLine("Escribe la Altura del triangulo: ");
// 	decimal altura = Convert.ToDecimal(Console.ReadLine());	

// 	decimal totals = Calculararea(basede , altura);	
// 	Console.WriteLine("El triangulo es > "+ totals);
// }
// proceso();

// # 3
// 3.- Diseñe un método que al ingresar un numero permita identificar si el numero es primo o no es primo ( sabiendo que los números primos solo son divisibles por la unidad y el valor del numero).

    static bool EsPrimo(int N)
    {
        bool primo;
        primo = true;
        int i;
        for (i = 2; i <= N - 1; i = i + 1)
        {
            if (N % i == 0)
            { primo = false; break; }
        }
        return primo;
    }
   
    {
        int num;
        Console.WriteLine("Ingrese un numero entero : ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("-------");
        if (EsPrimo(num))
            Console.WriteLine("{0} es PRIMO", num);
        else
            Console.WriteLine("{0} NO es PRIMO", num);
        Console.WriteLine("-------");
        Console.ReadKey();
    }



