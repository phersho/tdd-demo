# Demostración de Desarrollo Dirigido por Pruebas (TDD)

## Flujo de Trabajo

1. Escribir la prueba de fallo.
1. Escribir suficiente código para que la prueba pase; sólo suficiente.
1. _Refactor_
1. Repetir

### Requerimiento 1

Escribir un método `greet(name)` que interpole `name` en un saludo simple. Por ejemplo, cuando `name` es `"Bob"`, el método debe retornar la cadena `"Hello, Bob."`.

### Requerimiento 2

Manejar los nulos con otro mensaje `"my friend"`. Por ejemplo, cuando `name` es `null`, el método debe retornar la cadena `"Hello, my friend."`

### Requerimiento 3

Manejar gritos. Cuando `name` venga todo en mayúsculas, entonces el método debe _gritar_ el saludo. Por ejemplo, cuando `name` es `"JERRY"` el método debe retornr la cadena `"HELLO JERRY!"`.

### Requerimiento 4

Manejar dos nombres como entrada. Cuando `name` es un arreglo de dos nombres (o `varargs`, en lenguajes que lo soporten), ambos nombres deben ser desplegados. Por ejemplo, cuando `name` es `["Jill", "Jane"]`, el método debe retornar la cadena `"Hello, Jill and Jane"`.

#### Requerimiento 4.5

Para los dos nombres de entrada, asegurar se siguen los requerimientos 1 al 2.

## Otros

Tomado de [Greeting Kata](https://github.com/testdouble/contributing-tests/wiki/Greeting-Kata)
