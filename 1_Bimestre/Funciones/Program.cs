﻿// ejercicio1

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

