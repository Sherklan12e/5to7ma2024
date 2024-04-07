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

// Diseñar un algoritmo en el cual el usuario ingrese números indefinidamente. Si el número ingresado es cero se debe detener la carga e informar por pantalla la suma de los números positivos y el producto de los números negativos.
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

// Realizar un algoritmo en donde el usuario ingrese cadenas de caracteres de forma indefinida. Si la cadena ingresada es una cadena vacía (salto de línea), se debe informar por pantalla la cantidad de líneas ingresadas.

while()



//for
//uso habitual
// for (int i = 0; i < 5; i++)
//     Console.WriteLine("Mensaje" + (i + 1));

// for (int i = 0; i < 6; i++)
// {
//     Console.WriteLine(i + 1);
//     Console.WriteLine("Mensaje");
// }

// for (int i = 10; i > 6; i--) // i-- equivale a i = i - 1
// {
//     Console.WriteLine(i);
//     Console.WriteLine("Mensaje");
// }

// for (int i = 0; i <= 10; i = i + 2)
//     Console.WriteLine(i);

//uso poco usual
//for (int i = 0; i < 5; i++) ;

//for (; ; );

//while
// condicion es verdadera
// while(condicion) => condicion tiene un valor de verdad
// {
//      condicion es falsa
// }

// int i = 10;
// int j = 1;
// while (i < 10 && j > 0) //&& = and ; || = or
// {
//     Console.WriteLine(i);
//     i++;
// }


//do-while
// do {
//      condicion es falsa
// } while (condicion) => se ejecuta mientras la condicion es verdadera

// int i = 1;
// do
// {
//     Console.WriteLine(i);
//     i++;
// } while (i < 10);


//Ejercicio 1
// Realizar un algoritmo que informe por pantalla todos los números enteros del 100 al 200
// for (int numero = 100; numero <= 200; numero++)
//     Console.WriteLine(numero);

// for (int numero = 200; numero >= 100; numero--)
//     Console.WriteLine(numero);

//Ejercicio 5
// Realizar un algoritmo que informe por pantalla todos los números naturales desde el 1 (uno) hasta 
// el número natural que el usuario ingrese por teclado.
// int numero, i = 1;
// Console.Write("Ingrese un numero: ");
// numero = Convert.ToInt32(Console.ReadLine());

// while (i < numero)
// {
//     Console.WriteLine(i);
//     i++;
// }

//Ejercicio 11
//Hacer un algoritmo para mostrar por pantalla los números del 20 al 200 en orden creciente

// int i = 20;
// do
// {
//     Console.WriteLine(i);
//     i++;
// } while (i <= 200);