# Práctica 1 Compiladores

Proyecto realizada con GUI en C# para la clase de Compiladores impartida por el profesor Andrés Ortigoza Campos

## Parte 1
En esta parte solo se ha realizado la interfaz para el usuario, aún no tiene funcionalidad.


![image](https://user-images.githubusercontent.com/88689761/226269462-83f00901-65d8-421f-9951-172e1e95039b.png)

## Parte 2
En esta segunda parte se termino de realizar la presentación de la interfaz de usuario, se empezó a realizar la funcionalidad para el menú de "Crear Básico"

<p align="center">
  <img src="https://user-images.githubusercontent.com/88689761/226523607-48278c82-6642-4684-875b-2c61f49b3361.gif" />
</p>


## Parte 3
Pasaron 3 semanas despues de la ultima actualización, se implementaron todas las operaciones de los AFND's, actualmente se esta implementando la operacion AFND -> AFD y concluimos con la operación Union para Analizador Léxico.

<p align="center">
  <img src="https://user-images.githubusercontent.com/88689761/232969753-da34e953-efa0-44b4-94f9-a75ab4528b7d.gif" />
</p>

## Parte 4
Pasaron 4 semanas de la ultima actualización, se implemento la funcion E.R->AFND, se termino el Analizador Léxico y concluimos con el Analizador Sintáctico para la calculadora de Matrices con las siguientes operaciones
- Suma
- Resta
- Multiplicación

![image](https://github.com/Jose-Costa-M/Pr-ctica-1-Compiladores/assets/88689761/5b435bf9-c134-4cb5-9e54-c0c2ca6d8fb4)

Por otra parte se le implementaron más funcionalidades, por ejemplo, cargar archivos desde el explorador, generar la tabla de los AFD en un Excel para una mayor claridad.


## Parte 5

Paso 1 semana despues de la ultima actualización, se implementa el descenso recursivo para la creación de la tabla LL(1) la cual nos será de ayuda a analizar sintacticamente una cadena en base en una gramatica dada.

Para este ejemplo usamos la grámatica para las expresiones regulares dada por:

![image](https://github.com/Jose-Costa-M/Pr-ctica-1-Compiladores/assets/88689761/3e1b6d4c-40df-4000-b120-4d1c19695a16)

del cual nos brinda el siguiente resultado:

![image](https://github.com/Jose-Costa-M/Pr-ctica-1-Compiladores/assets/88689761/29a534ac-ec56-4c8e-b220-e0a692a282a9)

## Parte 6
Se agrega la columna 3 (Acciones) al DataGridView del Analizador Sintáctico de gramáticas

![image](https://github.com/Jose-Costa-M/Proyecto-Compiladores/assets/88689761/2bd94fbd-6ef8-4408-88e4-9fd85a9e1f15)

Tambien se prueba el descenso recursivo con la gramática de matrices que se ocupo en la parte 4 de operaciones con matrices

Esta es la gramática:


![image](https://github.com/Jose-Costa-M/Proyecto-Compiladores/assets/88689761/fa191ee3-e8b5-4c96-9995-0c6165c58f4b)


Resultado de ejecutar el programa


![image](https://github.com/Jose-Costa-M/Proyecto-Compiladores/assets/88689761/8ac98091-89d4-4ff3-8c57-8202977a624a)


## Parte 7 (Final)

Para terminar este proyecto, en el metodo AnalizarSin de la clase TablaLL1 se implementó la creación del arbol de derivación, creando una estructura de tipo Arbol que irá almacenando los nodos terminales y no terminales de la cadena ingresada.

Un ejemplo es la caden [a-z]+&[0-9]+ con el siguiente arbol:

![image](https://github.com/Jose-Costa-M/Proyecto-Compiladores/assets/88689761/e6442909-9247-42c6-acf1-1e81d518359f)




















