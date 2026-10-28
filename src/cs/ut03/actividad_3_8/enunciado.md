# UT03 - Actividad 8

En esta actividad trabajarás con un proyecto proporcionado por el profesor para localizar y contar los divisores de un número entero positivo, utilizando un bucle `while` y combinando estructuras de control.

Realiza los apartados en el orden indicado. Al finalizar cada uno, haz el correspondiente commit utilizando exactamente la descripción de la última columna.

| Apartado | Tarea a realizar | Descripción del commit |
|----------|------------------|------------------------|
| a | Copia el directorio `"src/cs/ut03/actividad_3_8"` proporcionado por el profesor en su repositorio, de manera que quede ubicado en **la misma ruta dentro de tu propio repositorio**. | `UT03A08a Copiado proyecto proporcionado por el profesor` |
| b | **(Repaso)** Comprueba que el número introducido esté comprendido entre **2 y 10000 (ambos incluidos)**. Si cumple esta condición, ejecuta el resto del programa. En caso contrario, muestra por consola un mensaje de error indicando que el número debe estar dentro de ese intervalo. | `UT03A08b Añadida comprobación del intervalo permitido` |
| c | **(Repaso)** Mejora el programa declarando dos constantes de tipo `"int"`, llamadas `"NUMERO_MIN"` y `"NUMERO_MAX"`, con los valores `2` y `10000`, respectivamente. Modifica la condición del apartado anterior para que utilice estas constantes en lugar de los valores numéricos literales. | `UT03A08c Incorporadas constantes para los límites del intervalo` |
| d | Plantea un bucle `"while"` que se ejecute mientras `"test_divisor"` sea **mayor o igual que 2**. Al final de cada iteración, resta `1` a esta variable para que, en la siguiente, se pruebe con el valor inmediatamente inferior. | `UT03A08d Añadido bucle while para recorrer posibles divisores` |
| e | En cada iteración del bucle `"while"`, incorpora en el lugar adecuado una comprobación para determinar si `"numero"` es divisible por `"test_divisor"`. En caso afirmativo, muestra por consola el mensaje `$"El número {test_divisor} es divisor de {numero}"`. | `UT03A08e Añadida comprobación y visualización de divisores` |
| f | Añade las variables e instrucciones necesarias para **contar cuántos divisores se han encontrado**. Al finalizar el bucle `"while"`, muestra por consola el mensaje `"Se han encontrado xxx divisores"`, sustituyendo `xxx` por la cantidad obtenida. | `UT03A08f Añadido recuento y visualización del número de divisores` |

## TIPS

### TIP 1. Anidamiento de estructuras de control

En esta actividad pondrás en práctica el **anidamiento de estructuras de control**, que consiste en colocar una estructura dentro de otra.

En concreto, tendrás que combinar **dos condicionales `if` y un bucle `while`**:

- **Primer `if`:** comprueba que el número introducido esté entre los valores mínimo y máximo permitidos.
- **Bucle `while`:** se ejecuta dentro del primer `if`, únicamente si el número es válido, y recorre los posibles divisores.
- **Segundo `if`:** se encuentra dentro del `while` y comprueba, en cada iteración, si el número es divisible por el valor que se está probando.

Por tanto, tendrás una estructura **`if` → `while` → `if`**, con tres niveles de anidamiento.

**Recuerda:** utiliza correctamente las llaves `{}` y la indentación para distinguir qué instrucciones pertenecen a cada bloque. Esto facilitará la lectura del código y evitará errores al combinar las estructuras.
