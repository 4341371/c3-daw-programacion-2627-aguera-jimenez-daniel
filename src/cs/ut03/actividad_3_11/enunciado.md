# UT03 - Actividad 11

En esta actividad completarás un programa que solicita un número entero y muestra su tabla de multiplicar del 1 al 10. Realiza los apartados en orden y, después de comprobar que cada uno funciona, crea el commit indicado.

| Apartado | Tarea a realizar | Descripción del commit |
|----------|------------------|------------------------|
| a | Copia el directorio `src/cs/ut03/actividad_3_11` proporcionado por el profesor en su repositorio, de manera que quede ubicado en **la misma ruta dentro de tu propio repositorio**. | `UT03A11a Copiado proyecto proporcionado por el profesor` |
| b | Desarrolla un bucle `for` que muestre por consola **la tabla de multiplicar del número introducido, desde el 1 hasta el 10**. Cada operación deberá aparecer en una línea independiente, siguiendo el formato indicado en los comentarios del programa. Por ejemplo, para el número `5`: `5 x 1 = 5`, `5 x 2 = 10`… hasta `5 x 10 = 50`. | `UT03A11b Implementada tabla de multiplicar mediante bucle for` |
| c | Mejora el programa para que **solo acepte números entre 1 y 10**, ambos incluidos. Si el número introducido está fuera de ese intervalo, deberá mostrar el mensaje `El número indicado debe estar entre 1 y 10` y no generar la tabla de multiplicar. | `UT03A11c Añadida validación del número introducido` |
| d | Mejora el programa para evitar que se produzca un error si el usuario introduce un valor que **no puede convertirse en un número entero** (por ejemplo, letras o texto). En ese caso, deberá mostrar el mensaje `Debes introducir un número válido` en lugar de interrumpirse con una excepción. | `UT03A11d Controlada entrada de valores no numéricos` |
| e | Mejora el programa para que, **si el usuario introduce un valor no numérico o un número fuera del intervalo de 1 a 10**, se muestre el mensaje de error correspondiente y se vuelva a solicitar otro número. Este proceso deberá repetirse **hasta que se introduzca un número entero válido entre 1 y 10**. Solo entonces se mostrará su tabla de multiplicar. | `UT03A11e Añadida repetición hasta introducir un número válido` |

## TIPS

**TIP 1. Mostrar texto sin salto de línea**

Recuerda que `Console.Write()` permite mostrar texto **sin añadir un salto de línea**, a diferencia de `Console.WriteLine()`. Así puedes mostrar varias cadenas consecutivamente en una misma línea.

**TIP 2. Repetir la petición de datos con `do-while`**

Puedes utilizar un bucle `do-while` para repetir todo el proceso hasta obtener un número válido. Para ello, declara una **variable booleana** que indique si todo ha ido bien. Su valor dependerá de si se produce una excepción al convertir el dato o si se llega a ejecutar correctamente el bucle `for` que muestra la tabla de multiplicar. Utiliza esa variable como condición para decidir si debes repetir el proceso.
