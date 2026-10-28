# UT03 - Actividad 10

En esta actividad completarás un programa que solicita una palabra y la va acortando progresivamente mediante un bucle `do-while`. Realiza los apartados en orden y crea el commit indicado después de completar y comprobar cada uno.

| Apartado | Tarea a realizar | Descripción del commit |
|----------|------------------|------------------------|
| a | Copia el directorio `src/cs/ut03/actividad_3_10` proporcionado por el profesor en su repositorio, de manera que quede ubicado en **la misma ruta dentro de tu propio repositorio**. | `UT03A10a Copiado proyecto proporcionado por el profesor` |
| b | Diseña un bucle `do-while` que, en cada iteración, **elimine el último carácter** de `palabra` y muestre por consola la cadena resultante. Por ejemplo, si introduces `mortadela`, la primera vez deberá mostrar `mortadel`, después `mortade`, y así sucesivamente hasta que la cadena quede vacía. El bucle deberá repetirse **mientras la cadena todavía contenga algún carácter**. | `UT03A10b Implementado bucle do-while para acortar la palabra` |
| c | Modifica el programa para que, en cada iteración, **elimine tanto el primer carácter como el último** de `palabra` y muestre por consola el resultado. Por ejemplo, si introduces `mortadela`, deberá mostrar `ortadel`, después `rtade`, y así sucesivamente hasta que no queden caracteres. Adapta la condición de permanencia del bucle para evitar errores cuando la cadena sea demasiado corta. | `UT03A10c Modificado bucle para eliminar ambos extremos de la palabra` |

## TIPS

**TIP 1. Eliminar el último carácter de una cadena con `Substring()`**

En C#, el método `Substring()` permite obtener una parte de una cadena de texto. Para eliminar el último carácter, puedes utilizar:

```csharp
palabra = palabra.Substring(0, palabra.Length - 1);
```

- `0`: indica que la subcadena comienza en el primer carácter.
- `palabra.Length`: devuelve el número de caracteres de la cadena.
- `palabra.Length - 1`: indica cuántos caracteres queremos conservar, excluyendo el último.

Por ejemplo, si `palabra` contiene `mortadela`, después de ejecutar esta instrucción contendrá `mortadel`.

**Importante:** esta operación debe realizarse cuando la cadena contiene al menos un carácter.

**TIP 2. La cadena vacía y cómo compararla**

En C#, una **cadena vacía** es una cadena de texto que no contiene ningún carácter. Se representa mediante dos comillas dobles seguidas: `""`.

```csharp
string palabra = "";
```

Puedes comprobar si una cadena está vacía utilizando los operadores de comparación:

```csharp
palabra == ""  // La cadena está vacía
palabra != ""  // La cadena NO está vacía
```

**Recuerda:** una cadena vacía (`""`) no es lo mismo que una cadena que contiene un espacio (`" "`).

**TIP 3. Comprobar la condición de salida mediante `Length`**

La propiedad `Length` permite conocer el **número de caracteres** que contiene una cadena de texto.

```csharp
string palabra = "mortadela";
Console.WriteLine(palabra.Length); // Muestra 9
```

Puedes utilizar esta propiedad para comprobar si la cadena todavía contiene caracteres:

```csharp
palabra.Length > 0
```

Esta expresión será `true` mientras la cadena contenga algún carácter y `false` cuando quede vacía.

**Recuerda:** en un bucle `do-while`, la condición se comprueba **después de ejecutar las instrucciones del bucle**. Por tanto, puedes utilizar `Length` para determinar cuándo debe terminar la repetición.
