# UT03 - Actividad 7

En esta actividad trabajarás con un bucle `while` para leer números enteros positivos y calcular su sumatorio, la cantidad de números introducidos y su valor medio.

Partirás de un proyecto proporcionado por el profesor que solicita un primer número y dispone de las variables `"numero"` y `"sumatorio"`. Completa las tareas en el orden indicado y, al finalizar cada apartado, realiza un commit utilizando exactamente la descripción de la última columna.

| Apartado | Tarea a realizar | Descripción del commit |
|----------|------------------|------------------------|
| a | Copia el directorio `"src/cs/ut03/actividad_3_7"` proporcionado por el profesor en su repositorio, de manera que quede ubicado en **la misma ruta dentro de tu propio repositorio**. | `UT03A07a Copiado proyecto proporcionado por el profesor` |
| b | Plantea un bucle `"while"` que se ejecute mientras la variable `"numero"` sea **mayor que cero**. En cada iteración, limítate a solicitar y leer un nuevo número, almacenándolo de nuevo en `"numero"`. El bucle terminará cuando se introduzca un número menor o igual que cero. | `UT03A07b Añadido bucle while para la lectura de números positivos` |
| c | Tras finalizar el bucle `"while"`, muestra por consola el valor de la variable `"sumatorio"`. | `UT03A07c Añadida visualización del sumatorio` |
| d | Completa el bloque del bucle `"while"` para que, en cada iteración, **se sume a `"sumatorio"` el valor actual de `"numero"`**, antes de leer el siguiente número. | `UT03A07d Añadida acumulación de valores en el sumatorio` |
| e | Añade las variables e instrucciones necesarias para **contar cuántos números positivos se han introducido**, sin incluir el cero o número negativo utilizado para terminar. Al finalizar el bucle, muestra también por consola la cantidad obtenida. | `UT03A07e Añadido recuento de números introducidos` |
| f | Añade al final del programa el cálculo del **valor medio de los números introducidos**, dividiendo `"sumatorio"` entre la cantidad de valores contabilizados. Utiliza una variable de un tipo que admita decimales para almacenar el resultado y muéstralo también por consola. | `UT03A07f Añadido cálculo y visualización del valor medio` |
| g | Modifica la visualización del valor medio para que se muestre **redondeado a un máximo de 4 decimales**, sin añadir ceros innecesarios al final. | `UT03A07g Añadido formato de hasta cuatro decimales para la media` |

## TIPS

**TIP 1. Conversión explícita a `double` (casting)**

En C#, cuando divides dos variables de tipo `"int"`, el resultado es también un entero y se pierde la parte decimal. Puedes convertir explícitamente uno de los operandos a `"double"` escribiendo `(double)` delante de él:

```csharp
int a = 7;
int b = 2;
double resultado = (double)a / b;
```

La variable `"resultado"` contendrá `3.5`, en lugar de `3`.

**TIP 2. Mostrar una variable `double` dentro de una cadena**

La **interpolación de cadenas** permite incorporar una variable a un mensaje escribiendo `$` delante de las comillas y el nombre de la variable entre llaves:

```csharp
double d = 12.345678;
Console.WriteLine($"El resultado es {d}");
```

Con la configuración regional española se mostrará:

```text
El resultado es 12,345678
```

El separador decimal depende de la configuración regional del equipo.

**TIP 3. Redondear un número a un determinado número de decimales**

En C# puedes utilizar el método `"Math.Round()"` para redondear un número. Su segundo argumento indica cuántas posiciones decimales deseas conservar:

```csharp
double d = 12.345678;
double redondeado = Math.Round(d, 3);
Console.WriteLine($"Valor redondeado: {redondeado}");
```

Con la configuración regional española se mostrará:

```text
Valor redondeado: 12,346
```

**Recuerda:** `"Math.Round()"` devuelve un valor numérico redondeado, no una cadena. Por defecto, cuando el valor está exactamente a mitad entre dos resultados posibles, utiliza el redondeo al par.
