####✨ PLANTILLA README – GitHub ✨

###Nombre del Proyecto:
Sistema de Notas (Manejo de Excepciones)

###Descripción
Este proyecto es una aplicación de consola desarrollada en C# que simula un sistema de registro de calificaciones para estudiantes. El objetivo principal es demostrar el uso correcto del manejo de excepciones mediante bloques try-catch-finally, validando que las entradas del usuario tengan el formato correcto y se encuentren dentro del rango permitido (0 a 100).

La aplicación fue desarrollada como una actividad práctica en el aula para el módulo formativo correspondiente.

###Tecnologías Utilizadas

Lenguaje: C# (.NET 6.0+)

Tipo de Proyecto: Aplicación de Consola (Console Application)

IDE: Visual Studio / VS Code

###Funcionalidades de la Aplicación

Registro de Datos: Solicita de forma interactiva el nombre del estudiante y su calificación final.

Validación de Formato (FormatException): Utiliza el método double.Parse() dentro de un bloque try. Si el usuario introduce letras o caracteres especiales no numéricos, el sistema captura el error de forma automática e informa al usuario mediante una alerta visual controlada.

Validación de Rango Lógico: El programa evalúa mediante una estructura condicional (if) que la nota se encuentre estrictamente entre 0 y 100. En caso de ingresar un valor fuera de rango, se despliega una interfaz de error crítico.

Cálculo de Estado: Si los datos ingresados son válidos, determina si el alumno aprueba (nota mayor o igual a 70) o si necesita reforzamiento (reprueba), mostrando un sello gráfico personalizado.

Garantía de Cierre de Procesos (finally): Implementa un bloque finally que asegura la conclusión del flujo del programa y notifica la finalización de la ejecución en cualquier escenario.

Estructura del Código Técnico

Bloque principal try-catch-finally: Controla la entrada y el procesamiento de los datos de la clase principal de forma segura para evitar interrupciones abruptas en la terminal.

Funciones de Dibujo: Métodos auxiliares estructurados independientes (DibujarCabecera, DibujarSelloAprobado, DibujarSelloReprobado, DibujarErrorRange, DibujarErrorFormat, DibujarErrorUnexpected) encargados de pintar la interfaz mediante el uso de códigos de escape ANSI y bordes estructurados.

###Contexto Académico

Institución: Instituto Pedro Feliciano Martínez

Nivel: Secundaria Técnico Profesional

Módulo Formativo: Desarrollo de Aplicaciones y Sistemas de Información

Curso: 5to. D1

Profesor: Gamalier Reyes del Carmen

###Autores
✨Jeimy Nathaly Concepción Ramírez. #7✨
