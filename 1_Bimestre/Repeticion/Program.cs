//Ciclos de repeticion - Bucles 

//Ejercicio 1
// Realizar un algoritmo que informe por pantalla todos los números enteros del 100 al 200.

// for (int i = 99; i< 200; i++){

//     Console.WriteLine( "Numero: " + (i+1) );
// }

// Ejercicio2
// Realizar un algoritmo que informe por pantalla todos los números impares enteros del 1 al 1000.
// for (int i = 1; i<1000; i++){
//     if (i%2!=0){
//         Console.WriteLine("numero-impar: " + (i));
        
//     }
// }

// Ejercicio3
// Hacer un algoritmo para mostrar por pantalla los números del 1000 al 500 en orden decreciente.
// for(int i= 1001; i> 500; i--){
//     Console.WriteLine("Numero: "+ (i-1) );
// }

// Ejercicio4
// Escribir un programa que informe por pantalla los múltiplos de 7 y de 5 comprendidos entre 50 y 500.

// for(int o=49; o < 500; o++){

//     if(o % 5==0 || o%7==0){
//         Console.WriteLine("numero: " + (o+1));
//     }
// }

// Ejercicio5
// Realizar un algoritmo que informe por pantalla todos los números naturales desde el 1 (uno) hasta el número natural que el usuario ingrese por teclado.
// int i = 0;
// int numero = Convert.ToInt32(Console.ReadLine());
// while(i < numero){
//     Console.WriteLine(i+1);
//     i++;
// }
// Hacer un algoritmo que permita al usuario ingresar un número entero y efectuar la suma de todos los números naturales desde 1 (uno) hasta el número ingreso. Informar el resultado de la suma por pantalla.
// int numero = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int suma = 0;
// while(i < numero){
//     suma = i + suma;
//     Console.WriteLine("Numero: " + (i+1) );
//     i++;

// }
// Console.WriteLine("La suma total de los numeros: " + suma);

// 7 Diseñar un algoritmo en el cual el usuario ingrese números indefinidamente. Si el número ingresado es cero se debe detener la carga e informar por pantalla la suma de los números positivos y el producto de los números negativos.
// int i = 1;
// int suma = 0;
// int producto = 1;
// while(i==1){
    
//     int numeroUsuario = Convert.ToInt32(Console.ReadLine());

//     if (numeroUsuario == 0)
//     {
//         i = 2;
//     }

//     if(numeroUsuario>0)
//     {
//         suma +=numeroUsuario;
//     }
    
//     else{
//         producto *= numeroUsuario;
//     }

// }
// Console.WriteLine("La suma de los todos los numero es: " + suma);

// Console.WriteLine("El producto de todos los numero negativos es: " + producto);

// ejercicio 8 Realizar un algoritmo en donde el usuario ingrese cadenas de caracteres de forma indefinida. Si la cadena ingresada es una cadena vacía (salto de línea), se debe informar por pantalla la cantidad de líneas ingresadas.

// int cantidadLineas = 0;

// while (true){
// Console.WriteLine("Ingrese una cadena de caracteres enter para acabar: ");
// string cadena = Console.ReadLine();
// if (string.IsNullOrWhiteSpace(cadena)){ 
//         break;
//     }

//     cantidadLineas++;
// }

// Console.WriteLine("Se ingreso " + cantidadLineas + " lineas.");



// Ejercicio9

// 9 Realizar un algoritmo en donde el usuario ingrese dos números enteros distintos indefinidamente. Se debe informar por pantalla la suma de dichos números siempre y cuando ambos números sean distintos. Si ambos números son iguales debe finalizar el algoritmo.

// int resultado = 0;
// int num1=0;
// int num2=0;
// do
// {
//     num1 = Convert.ToInt32(Console.ReadLine());
//     num2 = Convert.ToInt32(Console.ReadLine());

//     if (num1 != num2){
//         resultado = num1 + num2;
//         Console.WriteLine("Resultado " + resultado);

//     }
// }
// while (num1 != num2);

// 10 Realizar un algoritmo que informe por pantalla todos los números naturales desde el 1 (uno) hasta el número natural que el usuario ingrese por teclado.
// int numero = 0;
// int i = 0;
// numero = Convert.ToInt32(Console.ReadLine());
// do
// {
//     Console.WriteLine(i+1);

//     i++;
// }
// while ( numero > i);
// 11 Hacer un algoritmo para mostrar por pantalla los números del 20 al 200 en orden creciente
// int numero = 19;
// do
// {
//     Console.WriteLine(numero+1);
//     numero++;
// }
// while (numero < 200);


// 12 Realizar un algoritmo que permita al usuario ingresar por teclado la cantidad de agua caída en milímetros (número entero) día a día durante un mes (1 mes = 30 días). Se pide informar por pantalla el número de día en el que llovió más, el número de día en el que llovió menos y el promedio de lluvia caída (en milímetros) durante el mes.
// int num = 0;
// int numdia = 0;
// int numdiamenor = 0;
// int numeros = 0;
// int mayor = 0;
// int menor = 0;
// int promedio = 0;
// int diasum = 0;


// while ( num < 30){ 
//     Console.WriteLine("Ingrese la cantidad de agua del dia "+(num+1));
//     numeros = Convert.ToInt32(Console.ReadLine());
//     if (num == 0){
//         menor = numeros;
//     }
    
//     if (numeros > mayor){
//         mayor = numeros;
//         numdia = num+1 ;
//     }
//     else if (numeros < menor){
//         menor = numeros;
//         numdiamenor = num+1;
//     }
    
//     diasum = numeros + diasum;
//     num++;
// }
// promedio = diasum / 30;
// Console.Write("El dia donde llovio mas fue en " + numdia );
// Console.Write("El dia menor seria el "+ numdiamenor+" ");
// Console.WriteLine("El promedio seria en total de "+ promedio);


// 13 Realizar un programa que pida la estatura (en metros) y edad de un número indeterminado de personas. Posteriormente se debe informar por pantalla la estatura media de las personas mayores a 21 años y la estatura más alta de las personas menores a 21 años.

// decimal estatura = 0;
// int edad = 0;
// decimal promedio = 0;
// decimal sumatotal = 0;
// int bandera = 1;
// decimal  estaturaalta = 0;
// int persona = 0;
// while (true){
//     Console.WriteLine("Ingrese Su estatura de la persona "+ bandera + ": ");
//     estatura = Convert.ToDecimal(Console.ReadLine());
//     Console.WriteLine("Ingrese su edad de la persona "+ bandera + ": ");
//     edad = Convert.ToInt32(Console.ReadLine());
    
//     if (estatura == 0  || edad ==0 ){
//         break;
//     }
//     if (edad >21){
//         sumatotal = estatura + sumatotal;
//     }else{
//         if (estatura > estaturaalta){
//             estaturaalta = estatura;
//             persona = bandera;
//         }
//     }
//     bandera++;
// }   

// promedio = sumatotal / bandera;
// Console.WriteLine("La estatura medio de las personas mayores a 21 es: "+ promedio);
// Console.WriteLine("La estatura alta de las personas menorese de 21 es: " + persona);

// 14 Realizar un algoritmo que lea una cantidad indefinida de números naturales y se termine la carga con el número cero. Posteriormente informar por pantalla cuál fue el número mayor ingresado y que cantidad de veces fue ingresado.
// int numero1 = 0;
// int bandera = 1;
// int cantidad =0;
// int mayor = 0;
// int index = 0;

// while (true){
//     Console.WriteLine("Ingrese el numero : " + bandera);
//     numero1 = Convert.ToInt32(Console.ReadLine());
//     if (numero1 == 0){
//         break;
//     }
    
//     if (numero1 > mayor){
//         mayor = numero1;
//         cantidad = 1;
//     }
//     else if (numero1== mayor){
//         cantidad++;
//     }
//     bandera ++; 
// }

// Console.WriteLine("El numero mayor es es: " + mayor);
// Console.WriteLine("y la cantidad de veces es: " + cantidad);

