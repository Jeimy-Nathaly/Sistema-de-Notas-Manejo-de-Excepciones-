### ✨ PLANTILLA README – GitHub ✨

####  Nombre del Proyecto:
Sistema de Notas (Manejo de Excepciones)

#### Descripción
Este proyecto es una aplicación de consola desarrollada en C# que simula un sistema de registro de calificaciones para estudiantes. El objetivo principal es demostrar el uso correcto del manejo de excepciones mediante bloques try-catch-finally, validando que las entradas del usuario tengan el formato correcto y se encuentren dentro del rango permitido (0 a 100).

La aplicación fue desarrollada como una actividad práctica en el aula para el módulo formativo correspondiente.

### Tecnologías Utilizadas

- Lenguaje: C# (.NET 6.0+)

- Tipo de Proyecto: Aplicación de Consola (Console Application)

- IDE: Visual Studio / VS Code

### Funcionalidades de la Aplicación

Registro de Datos: El programa te pide escribir el nombre del estudiante y luego su nota.
![imagen alt](https://raw.githubusercontent.com/Jeimy-Nathaly/Sistema-de-Notas-Manejo-de-Excepciones-/e4b4080eb5931858588131a76d63b9f68cea6d8c/4.png)


Manejo de FormatException: Al ingresar letras en vez de números, double.Parse() activa el error dentro del try. El programa lo frena con el catch y, en lugar de cerrarse, muestra un aviso en la consola indicando que solo se permiten números.
![imagen alt](https://github.com/Jeimy-Nathaly/Sistema-de-Notas-Manejo-de-Excepciones-/blob/main/2.png?raw=true)


Control de notas falsas: El programa usa un if para revisar que la nota esté entre 0 y 100. Si pones un número fuera de ese rango (como 150 o un número negativo), salta un aviso de error en la pantalla.

![imagen alt](https://github.com/Jeimy-Nathaly/Sistema-de-Notas-Manejo-de-Excepciones-/blob/main/3.png?raw=true)

Resultado del estudiante: Si la nota es correcta y es de 70 o más, calcula que está aprobado y pinta un sello de felicidades. Si es menor de 70, sale como reprobado y muestra el cartel de que necesita reforzamiento.

![imagen alt](https://github.com/Jeimy-Nathaly/Sistema-de-Notas-Manejo-de-Excepciones-/blob/main/1.png?raw=true)

Garantía de Cierre de Procesos (finally): Se utilizo un bloque finally que asegura  la finalización del programa.
![imagen alt](https://github.com/Jeimy-Nathaly/Sistema-de-Notas-Manejo-de-Excepciones-/blob/main/5.png?raw=true)

### Contexto Académico

- Institución: Instituto Pedro Feliciano Martínez

- Nivel: Secundaria Técnico Profesional

- Módulo Formativo: Desarrollo de Aplicaciones y Sistemas de Información

- Curso: 5to. D1

- Profesor: Gamalier Reyes del Carmen

### Autores
✨Jeimy Nathaly Concepción Ramírez. #7✨
