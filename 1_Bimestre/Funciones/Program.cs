
// Realizar un algoritmo que permita ingresar un número entero que represente un día de la semana (0:Domingo, 1:Lunes, 2:Martes, 3:Miércoles, 4:Jueves, 5:Viernes, 6:Sábado). Informar por pantalla si el valor ingresado representa un día hábil (Lunes a Viernes)l, fin de semana o no corresponde a un día de la semana.

// int numero = Convert.ToInt32(Console.ReadLine());

// if (numero > 7)
// {
// 	Console.WriteLine("Este no se encuentra en un numero de la semana");
// }
// else
// {
// 	switch (numero)
// 	{
// 		case 0:
// 			Console.WriteLine("Domingo");
// 			Console.WriteLine("Fin de semana");
// 			break;
// 		case 1:
// 			Console.WriteLine("Lunes");
// 			Console.WriteLine("Dia habitual");
// 			break;
// 		case 2:
// 			Console.WriteLine("Martes");
// 			Console.WriteLine("Dia habitual");
// 			break; 
// 		case 3:
// 			Console.WriteLine("Miercoles");
// 			Console.WriteLine("Dia habitual");
// 			break;
// 		case 4:
// 			Console.WriteLine("Jueves");
// 			Console.WriteLine("Dia habitual");
// 			break;
// 		case 5:
// 			Console.WriteLine("Viernes");
// 			Console.WriteLine("Dia habitual");
// 			break;
// 		case 6:
// 			Console.WriteLine("Sabado");
// 			Console.WriteLine("Fin de semana");
// 			break;
// 	}
// }

// Realizar un algoritmo que permita ingresar números enteros hasta que se ingrese el cero e informar por pantalla:
// La suma de todos números positivos
// La cantidad total de números ingresados 
// decimal suma = 0;
// while(true)
// {
// 	decimal numero = Convert.ToDecimal(Console.ReadLine());
// 	if(numero == 0)
// 	{
// 		break;
// 	}
// 	if(numero > 0)
// 	{
// 		suma = suma + numero;
// 	}
	
// }

// Console.WriteLine("La suma de los numeros" + suma);



// Realizar un algoritmo para mostrar por pantalla los números del 20 al 200 en orden creciente



// for(int i = 19; i<200; i++)
// {
// 	Console.WriteLine("El numero: "+ (1+i));
// }




























// ejercicio1

// int numero1 = Convert.ToInt32(Console.ReadLine());
// bool validar(int numero){
//     return numero > 0;
// }
// if (validar(numero1)){
//     Console.WriteLine("El numero es positivo");
// }else if (numero1==0){
//     Console.WriteLine("El numero es neutro");
// }
// else{
//     Console.WriteLine("El numero es negativo");
// }
// ejercicio2

// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// bool EsPar(int num){

//     return (num % 2)==0;
// }
// void validar(int num1, int num2, int num3, out int count, out int impar){
//     count = 0;
//     impar = 0;
//     if (EsPar(num1)){
//         count++;
//     }
//     else{
//         impar++;
//     }
//     if (EsPar(num2)){
//         count++;
//     }else{
//         impar++;
//     }
	
//     if (EsPar(num3)){
//         count++;
//     }else{
//         impar++;
//     }
// }
// int count , impar; 

// validar(num1,num2,num3, out count, out impar);
// Console.WriteLine("La cantidad de numeros pares son: " + count);
// Console.WriteLine("La cantidad de numeros impares son: "+ impar);

// ejercicio3
// Ejercicio 3
// Ingresa 3 (tres) números enteros y validar mediante una función si cada número se encuentra dentro del rango de -100 a 100. Se debe informar por pantalla el valor mínimo, el máximo y el promedio para aquellos números.  


// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());
// int promedio(int num1, int num2, int num3){
	
//     int promedio = 0;
//     promedio = num1 + promedio;
//     promedio = num2 + promedio;
//     promedio = num3 + promedio;
//     promedio = promedio /3;
//     return promedio;

// }
// bool ValidaNum(int num){
//     return num >= -100 && num <= 100;
	  
// }
// void Valorminimo(int num1 , int num2, int num3, out int minimo , out int maximo){
//     minimo = maximo = num1;
//     if (ValidaNum(num1)){
//         if (num1 > maximo){
//             maximo = num1;
//         }
//         if (num1 < minimo){
//             minimo = num1;
//         }
//     }
//     if (ValidaNum(num2)){
//         if (num2 > maximo){
//             maximo = num2;
//         }
//         if (num2 < minimo){
//             minimo = num2;
//         }
//     }
//     if (ValidaNum(num3)){
//         if (num3 > maximo){
//             maximo = num3;
//         }
//         if (num3 < minimo){
//             minimo = num3;
//         }
//     }
// }
// int minimo,maximo ;
// int numpromedo = promedio(num1,num2, num3);

// Valorminimo(num1,num2,num3,out minimo, out maximo);
// Console.WriteLine("El numero minimo: "+ minimo );
// Console.WriteLine("El numero maximo: " + maximo);
// Console.WriteLine("Promedio: " + numpromedo);


// Ejercicio 4
// Realizar un programa que se ingresen calificaciones (de 1 a 10) de forma indefinida y mediante una función escribir por pantalla la calificación en texto, por ejemplo si se ingresa 7 se debe informar “siete”. La carga debe finalizar cuando se ingresa la nota 0 (cero).

// string Calificaion(int cali) 
// {
// 	if (cali==1)
// 	{
// 		return "uno";
// 	}
// 	else if (cali==2)
// 	{
// 		return "dos";
// 	}
// 	else if (cali==3)
// 	{
// 		return "tres";
// 	}
// 	else if (cali==4)
// 	{
// 		return "cuatro";
// 	}
// 	else if (cali==5)
// 	{
// 		return "cinco";
// 	}
// 	else if (cali==6)
// 	{
// 		return "seis";
// 	}
// 	else if (cali==7)
// 	{
// 		return "siete";
// 	}
// 	if (cali==8)
// 	{
// 		return "ocho";
// 	}
// 	else if (cali==9)
// 	{
// 		return "nueve";
// 	}
// 	else if (cali==10)
// 	{
// 		return "diez";
// 	}
// 	else
// 	{
// 		return "Numero fuera de rango";
// 	}
// };
// int numero  = 0;
//  while (true){ 
// 	Console.WriteLine("Escribe el numero pe causa : ");
// 	numero = Convert.ToInt32(Console.ReadLine());
// 	if (numero == 0)
// 	{
// 		break;
// 	}
// 	else
// 	{
// 	string calif = Calificaion(numero);
	
// 	Console.WriteLine(calif);
		
// 	}
// };
// Ejercicio 5
// Crear una función que calcule la temperatura media de un día a partir de la temperatura máxima y mínima. Crear un programa principal, que utilizando la función anterior, vaya pidiendo la temperatura máxima y mínima de cada día y vaya informando por pantalla la temperatura media. El programa pedirá previamente el número de días que se van a introducir.

// int calcularatemparura(int maximo , int minima)
// {
// 	int promedio = 0;
// 	promedio = (maximo + minima) / 2 ;
// 	return promedio;
// };
// int count = 0;
// int calculo = 0;

// Console.WriteLine("Escribe cuantos Dias: ");
// int pregunta = Convert.ToInt32(Console.ReadLine());

// while (true)
// {	
// 	Console.WriteLine("dia"+ (count +1));
	
	
// 	Console.WriteLine("Escribe la temperatura maxima!: ");
// 	int numero1 = Convert.ToInt32(Console.ReadLine());
// 	Console.WriteLine("Escribe la temperatura minima!: ");
// 	int numero2 = Convert.ToInt32(Console.ReadLine());
	
	
// 	calculo = calcularatemparura(numero1,numero2);
// 	Console.WriteLine("Promedio: "+calculo);
// 	count++;
// 	if (pregunta==count)
// 	{
// 		break;
// 	}
	
// };

// Ejercicio 6 
// Escribir un programa que permita ingresar una fecha compuesta por el campo día, mes y año (variables enteras). Validar mediante una función el día teniendo en cuenta si el año es bisiesto. Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400 (2000 es bisiesto pero 1900 no).  Informar por pantalla si el año es bisiesto o no.
// // 




// Ejercicio 7
// Escribir un programa que permita ingresar una fecha compuesta por el campo día, mes y año. Validar mediante una función si la cantidad de días corresponde a cada mes del año, por ejemplo enero tiene 31 días. Imprimir por pantalla si la cantidad de días es correcta para el mes ingresado.

// Ejercicio 8
// Realizar un programa que permita el ingreso de varios valores que correspondan a la temperatura promedio de cada uno de los meses de un año. Mediante una función informar por pantalla si la temperatura es cálida (mayor o igual a 23°) o frío (menor o igual a 18°), en otro caso no se debe informar (temperatura templada).





// int a = 100, b = 200;

//INVOCAR O LLAMAR A UNA FUNCION
//en la variable "resultado" se almacena el valor que retorna 
//la funcion
// int resultado = Sumar(3, 5);
// resultado = Sumar(a, b);

//DEFINIR UNA FUNCION
// para definir una funcion se debe definir:
//- Tipo de dato de retorno
//- Nombre de la funcion 
//- Parametros

//Tipo de dato de retorno:
//Si la funcion debe retornar un valor el tipo de dato puede ser: int, float, double, bool, string, etc
//Si la funcion NO retorna ningun valor se debe utilizar el tipo de dato: void

//Nombre de una funcion debe seguir la convencion de "verbo en infinitivo + sustantivo"

//Parametros:
//Los parametros son opcionales en tal caso se debe colocar () parentesis vacios
//Si se define uno o mas paametros, se debe colocar por parametro: el tipo de dato y el nombre
//del parametro

// int Sumar(int numero1, int numero2)
// {
//     int resultado = numero1 + numero2;
//     return resultado;
// }

// Console.WriteLine(resultado);


//PARAMETROS DE UNA FUNCION
//al momento de invocar una funcion se debe respectar el orden en el cual 
//se definieron los tipos de datos
// Infomar(resultado, "El resultado es: ");

// void Infomar(int valor, string mensaje)
// {
//     Console.WriteLine(mensaje + valor);
// }

// resultado = Sumar2(3, 5);
// resultado = Sumar3(30, 50);

// Console.WriteLine(resultado);

//FORMAS DECLARACION FUNCIONES
// int Sumar2(int numero1, int numero2)
// {
//     int suma = numero1 + numero2;
//     return suma;
// }

// int Sumar3(int numero1, int numero2)
// {
//     return numero1 + numero2;
// }

// int Sumar4(int numero1, int numero2) => numero1 + numero2;

