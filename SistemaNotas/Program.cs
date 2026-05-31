using System;
using System.Text;

namespace SistemaNotas
{
    class Program
    {
        // Códigos ANSI para Colores y Estilos
        const string Reset = "\x1B[0m";
        const string Bold = "\x1B[1m";
        const string Cyan = "\x1B[36m";
        const string Green = "\x1B[32m";
        const string Yellow = "\x1B[33m";
        const string Red = "\x1B[31m";
        const string Magenta = "\x1B[35m";
        const string White = "\x1B[37m";

        static void Main(string[] args)
        {
            // Forzar codificación UTF-8 para que los bordes se vean bien
            Console.OutputEncoding = Encoding.UTF8;

            DibujarCabecera();

            try
            {
                Console.WriteLine($"{White}\n┌────────────────────────────────────────┐{Reset}");
                Console.WriteLine($"{White}│            REGISTRO DE DATOS           │{Reset}");
                Console.WriteLine($"{White}└────────────────────────────────────────┘{Reset}\n");

                // Solicitar nombre
                Console.Write($" {Bold}»{Reset} Ingrese el {Cyan}nombre{Reset} del estudiante: {White}");
                string nombre = Console.ReadLine();

                // Solicitar y validar la nota
                Console.Write($" {Bold}»{Reset} Ingrese la {Magenta}nota{Reset} (0-100): {White}");

                // Usamos double.Parse() como pide el requisito
                double nota = double.Parse(Console.ReadLine());

                Console.WriteLine($"{White}\n┌────────────────────────────────────────┐{Reset}");
                Console.WriteLine($"{White}│               RESULTADOS               │{Reset}");
                Console.WriteLine($"{White}└────────────────────────────────────────┘{Reset}\n");

                // Validar el rango de la nota
                if (nota < 0 || nota > 100)
                {
                    DibujarErrorRange();
                }
                else
                {
                    Console.WriteLine($" {White}{Bold}Estudiante:{Reset} {nombre}");
                    Console.WriteLine($" {White}{Bold}Nota final:{Reset} {GetNotaColor(nota)}{nota}{Reset}");

                    if (nota >= 70)
                    {
                        Console.WriteLine($"\n {Bold}Estado:{Reset} {Green}✅ APROBADO ✅{Reset}");
                        DibujarSelloAprobado();
                    }
                    else
                    {
                        Console.WriteLine($"\n {Bold}Estado:{Reset} {Red}❌ REPROBADO ❌{Reset}");
                        DibujarSelloReprobado();
                    }
                }
            }
            // Captura errores de formatoಥ_ಥ
            catch (FormatException)
            {
                DibujarErrorFormat();
            }
            // Capturar cualquier otro error:-D
            catch (Exception ex)
            {
                DibujarErrorUnexpected(ex);
            }
            // Bloque que se ejecuta siempre al final (❁´◡`❁)
            finally
            {
                Console.WriteLine($"{White}\n┌────────────────────────────────────────┐{Reset}");
                Console.WriteLine($"{White}│               FINALIZADO               │{Reset}");
                Console.WriteLine($"{White}└────────────────────────────────────────┘{Reset}\n");

                Console.WriteLine($"{Bold}{White} Presione {Reset}{Cyan}[cualquier tecla]{Reset}{Bold}{White} para salir...{Reset}");
                Console.ReadKey();
            }
        }

        // --- Funciones de Dibujo ---( •̀ ω •́ )✧

        static void DibujarCabecera()
        {
            Console.Clear();
            Console.WriteLine($"{Yellow}{Bold}");
            Console.WriteLine(@" ╔════════════════════════════════════════════════════╗");
            Console.WriteLine(@" ║                                                    ║");
            Console.WriteLine(@" ║   📚  S I S T E M A    D E    N O T A S   📚   ║");
            Console.WriteLine(@" ║                                                    ║");
            Console.WriteLine(@" ╚════════════════════════════════════════════════════╝");
            Console.WriteLine($"{Reset}");
        }

        static void DibujarSelloAprobado()
        {
            Console.WriteLine(Green + Bold);
            Console.WriteLine("    ╔══════════════════════════════════╗");
            Console.WriteLine("    ║  🌟 ¡FELICIDADES, PASASTE! 🌟    ║");
            Console.WriteLine("    ╚══════════════════════════════════╝");
            Console.WriteLine(Reset);
        }

        static void DibujarSelloReprobado()
        {
            Console.WriteLine(Red + Bold);
            Console.WriteLine("    ╔══════════════════════════════════╗");
            Console.WriteLine("    ║  ❌ NECESITAS REFORZAMIENTO ❌   ║");
            Console.WriteLine("    ╚══════════════════════════════════╝");
            Console.WriteLine(Reset);
        }
        static void DibujarErrorRange()
        {
            Console.WriteLine($"{Red}{Bold}");
            Console.WriteLine(@"  / \______________________________________________/ \");
            Console.WriteLine(@" (\_/                                              \_/)");
            Console.WriteLine(@"  |                                                |");
            Console.WriteLine(@"  |    ¡ERROR CRÍTICO DE RANGO DE NOTA!            |");
            Console.WriteLine(@"  |    La nota debe estar entre 0 y 100.           |");
            Console.WriteLine(@"  |                                                |");
            Console.WriteLine(@"  \_/______________________________________________\_/");
            Console.WriteLine(@"   \_/                                              \_/");
            Console.WriteLine($"{Reset}");
        }

        static void DibujarErrorFormat()
        {
            Console.WriteLine($"{Red}{Bold}");
            Console.WriteLine("    ╔════════════════════════════════════════╗");
            Console.WriteLine("    ║           ALERTA DE FORMATO            ║");
            Console.WriteLine("    ╠════════════════════════════════════════╣");
            Console.WriteLine("    ║ [!] Error: Solo se permiten números    ║");
            Console.WriteLine("    ╚════════════════════════════════════════╝");
            Console.WriteLine(Reset);
        }

        static void DibujarErrorUnexpected(Exception ex)
        {
            Console.WriteLine($"{Magenta}{Bold}");
            Console.WriteLine("    ╔════════════════════════════════════════╗");
            Console.WriteLine("    ║           FALLA DEL SISTEMA            ║");
            Console.WriteLine("    ╠════════════════════════════════════════╣");
            Console.WriteLine("    ║ [!] It's me. Error inesperado detectado║");
            Console.WriteLine("    ╚════════════════════════════════════════╝");
            Console.WriteLine($"{White}    Detalles: {ex.Message}{Reset}");
        }

        static string GetNotaColor(double nota)
        {
            if (nota >= 90) return Green;
            if (nota >= 70) return Cyan;
            if (nota >= 60) return Yellow;
            return Red;
        }
    }
}