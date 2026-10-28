# UT03 - Actividad 9

En esta actividad completarás un programa que solicita una palabra y un número de repeticiones. Sigue los apartados en orden, comprueba el funcionamiento del programa y realiza el commit indicado después de cada apartado.

| Apartado | Tarea a realizar | Descripción del commit |
|----------|------------------|------------------------|
| a | Copia el directorio `src/cs/ut03/actividad_3_9` proporcionado por el profesor en su repositorio, de manera que quede ubicado en **la misma ruta dentro de tu propio repositorio**. | `UT03A09a Copiado proyecto proporcionado por el profesor` |
| b | Completa el programa para que muestre por consola la palabra introducida **tantas veces como indique el valor de `repeticiones`**, utilizando para ello un bucle. | `UT03A09b Añadida repetición de la palabra introducida` |
| c | Modifica el programa para que las palabras **se muestren todas en una misma línea, separadas por comas**, en lugar de aparecer una en cada línea. Por ejemplo, si introduces `pepe` y `3` repeticiones, el resultado deberá ser `pepe,pepe,pepe,` (observa que también hay una coma después de la última palabra). | `UT03A09c Modificada salida para mostrar palabras separadas por comas` |
| d | Mejora el programa para que **no se muestre una coma después de la última repetición** y se **genere un salto de línea al finalizar**. Por ejemplo, si introduces `pepe` y `3` repeticiones, el resultado deberá ser `pepe,pepe,pepe`, seguido de un salto de línea. | `UT03A09d Eliminada coma final y añadido salto de línea` |

## TIPS

**TIP 1. Mostrar texto sin saltar de línea: `Console.Write()`**

- `Console.WriteLine()` muestra el texto y añade un salto de línea.
- `Console.Write()` muestra el texto sin añadir un salto de línea, por lo que la siguiente salida continúa en la misma línea.

Por ejemplo:

```csharp
Console.Write("Hola,");
Console.Write("¿qué tal?");
Console.WriteLine();
```

Resultado:

```text
Hola,¿qué tal?
```

Puedes utilizar `Console.Write()` dentro de un bucle para mostrar varias palabras en una misma línea.
