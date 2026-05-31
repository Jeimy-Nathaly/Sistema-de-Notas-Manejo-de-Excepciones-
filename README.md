## ✨ PLANTILLA README – GitHub ✨

###  Nombre del Proyecto:
Sistema de Notas (Manejo de Excepciones)

### Descripción
Este proyecto es una aplicación de consola desarrollada en C# que simula un sistema de registro de calificaciones para estudiantes. El objetivo principal es demostrar el uso correcto del manejo de excepciones mediante bloques try-catch-finally, validando que las entradas del usuario tengan el formato correcto y se encuentren dentro del rango permitido (0 a 100).

La aplicación fue desarrollada como una actividad práctica en el aula para el módulo formativo correspondiente.

### Tecnologías Utilizadas

- Lenguaje: C# (.NET 6.0+)

- Tipo de Proyecto: Aplicación de Consola (Console Application)

- IDE: Visual Studio / VS Code

### Funcionalidades de la Aplicación

Registro de Datos: El programa solicita escribir el nombre del estudiante y luego su nota.
![imagen alt](https://raw.githubusercontent.com/Jeimy-Nathaly/Sistema-de-Notas-Manejo-de-Excepciones-/e4b4080eb5931858588131a76d63b9f68cea6d8c/4.png)


Control de letras o campos vacíos: Si se intentan ingresar letras o texto en lugar de números, el sistema lo detecta automáticamente. En vez de cerrarse con error, muestra un cuadro de advertencia en la consola indicando que solo se permiten números.

![imagen alt](https://github.com/Jeimy-Nathaly/Sistema-de-Notas-Manejo-de-Excepciones-/blob/main/2.png?raw=true)


Control de notas fuera de rango: El sistema revisa que la calificación esté entre 0 y 100. Si se digita un número fuera de este límite (como un número negativo o mayor a 100), salta un aviso de error crítico en la pantalla.

![imagen alt](https://github.com/Jeimy-Nathaly/Sistema-de-Notas-Manejo-de-Excepciones-/blob/main/3.png?raw=true)

Resultado del estudiante: Si la nota es válida y es de 70 o más, el sistema determina que está aprobado y muestra un sello de felicitaciones. Si es menor de 70, sale como reprobado junto a un cartel de reforzamiento. (en este caso es aprobado)

![imagen alt](https://github.com/Jeimy-Nathaly/Sistema-de-Notas-Manejo-de-Excepciones-/blob/main/1.png?raw=true)

Cierre ordenado del sistema: Al finalizar cualquier evaluación o reporte de error, la aplicación asegura una salida limpia mostrando un mensaje para presionar cualquier tecla antes de salir.

![imagen alt](https://github.com/Jeimy-Nathaly/Sistema-de-Notas-Manejo-de-Excepciones-/blob/main/5.png?raw=true)

### Contexto Académico

- Institución: Instituto Pedro Feliciano Martínez

- Nivel: Secundaria Técnico Profesional

- Módulo Formativo: Desarrollo de Aplicaciones y Sistemas de Información

- Curso: 5to. D1

- Profesor: Gamalier Reyes del Carmen

### Autores
✨Jeimy Nathaly Concepción Ramírez. #7✨
