# UT03 - Tarea 1

En esta tarea deberás desarrollar los diferentes apartados del enunciado, utilizando las estructuras de control indicadas en cada uno de ellos. El proyecto inicial incluye un archivo `Program.cs` con espacios reservados para implementar el código correspondiente.

**Puedes resolver los apartados en el orden que prefieras.** No es necesario seguir la secuencia `a`, `b`, `c`… ni realizar los commits en ese orden.

No obstante, se recomienda realizar **un único commit por apartado**, utilizando la descripción indicada en el enunciado e incluyendo exclusivamente los cambios relacionados con ese apartado. De esta forma, cada commit permitirá identificar y evaluar fácilmente el trabajo realizado.

## Apartado a. Preparación del proyecto

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| a.1 | Copia el directorio `src/cs/ut03/tarea_3_1` proporcionado por el profesor en su repositorio, de manera que quede ubicado en **la misma ruta dentro de tu propio repositorio**. |
| **Commit:** | `UT03T1a Copiado proyecto proporcionado por el profesor` |

## Apartado b. Estructuras condicionales

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| b.1 | Solicita al usuario que introduzca **dos cadenas de texto**. Compara ambas cadenas y muestra por consola un mensaje indicando si son `"Iguales"` o `"Diferentes"`. |
| b.2 | Mejora el apartado anterior para que, si las cadenas son diferentes, **vuelva a comparar, pero ahora sus versiones en mayúsculas (ver TIP 1)**. Si ahora coinciden, deberá mostrar `"Semejantes"` en lugar de `"Diferentes"`. |
| **Commit:** | `UT03T1b Condicionales` |

## Apartado c. Bucle `for`

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| c.1 | Utiliza un bucle `for` para mostrar por consola una **cuenta atrás desde 10 hasta 0**, ambos incluidos, mostrando cada número en una línea independiente. |
| c.2 | Modifica el programa para que solicite al usuario **el número desde el que debe comenzar la cuenta atrás**, en lugar de comenzar siempre desde 10. La cuenta atrás deberá finalizar igualmente en 0. |
| **Commit:** | `UT03T1c Bucle for` |

## Apartado d. Bucle `while`

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| d.1 | Solicita al usuario un **número entero**. Utiliza un bucle `while` para que, mientras el número sea menor que `10000`, **lo muestre por consola y después lo multiplique por 10**. |
| d.2 | Al finalizar el bucle, muestra el mensaje `"Bucle finalizado con el valor X"`, donde `X` será el **valor actual de la variable que ha ido almacenando los números durante el bucle**. |
| **Commit:** | `UT03T1d Bucle while` |

## Apartado e. Bucle `do-while`

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| e.1 | Utiliza un bucle `do-while` para solicitar repetidamente al usuario que introduzca una palabra. El bucle deberá continuar **mientras la palabra introducida no sea la cadena vacía (`""`)**. |
| e.2 | Mejora el programa para que, **al finalizar el bucle, muestre por consola todas las palabras introducidas, separadas por espacios** (ver TIP 2). |
| **Commit:** | `UT03T1e Bucle do-while` |

## Apartado f. Combinación de condicionales y bucles

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| f.1 | Desarrolla un programa que muestre por consola **los 20 primeros números enteros positivos (del 1 al 20)**, mostrando cada número en una línea independiente. |
| f.2 | Mejora el programa para que **los números menores de 10 se muestren con un cero delante**, de manera que todos tengan dos dígitos (`01`, `02`, `03`… `09`, `10`, `11`… `20`). |
| f.3 | Utiliza una estructura `switch-case` para que los valores `01`, `10` y `20` aparezcan acompañados de los textos `"primero"`, `"mitad"` y `"último"`, respectivamente. El resto de los números deberán mostrarse sin texto adicional. |
| **Commit:** | `UT03T1f Condicionales y bucles combinados` |

## Apartado g. Tratamiento de excepciones con `try-catch-finally`

| Apartado | Tarea a realizar / Descripción del commit |
|---:|---|
| g.1 | Solicita al usuario que introduzca un **número de repeticiones**. Utiliza `try-catch` para capturar los posibles errores al convertir el dato introducido a un número entero. Si se produce una excepción, muestra por consola el mensaje `"El número introducido no es válido"`. |
| g.2 | Mejora el programa para que, **si se produce una excepción**, además de mostrar el mensaje de error, se asigne el valor `0` a la variable `repeticiones`. |
| g.3 | Mejora el programa utilizando `finally` para garantizar que la siguiente instrucción **se ejecute siempre, tanto si se produce una excepción como si no**: `Console.WriteLine($"El número de repeticiones ha sido: {repeticiones}");` |
| **Commit:** | `UT03T1g Tratamiento de excepciones` |

## TIPS

**TIP 1. Comparar cadenas sin distinguir mayúsculas y minúsculas**

Recuerda que, si `a` y `b` son cadenas de texto, `a.ToUpper()` y `b.ToUpper()` devuelven sus respectivas versiones convertidas a mayúsculas.

Por tanto, puedes compararlas así:

```csharp
a.ToUpper() == b.ToUpper()
```

Esta comparación permite comprobar si ambas cadenas contienen el mismo texto, independientemente de las mayúsculas y minúsculas utilizadas.

**TIP 2. Acumular palabras mediante concatenación**

Para conservar todas las palabras introducidas, declara una **variable de tipo `string`**, inicialmente vacía. En cada iteración del bucle, concatena a esa variable la nueva palabra introducida, añadiendo también un espacio para separarla de las anteriores.

Al finalizar el bucle, podrás mostrar todas las palabras acumuladas en esa variable.
