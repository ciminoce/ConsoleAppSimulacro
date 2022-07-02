using System;

namespace ConsoleAppSimulacro
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, minutos, segundos;
            string indicador;
            string hora12, hora24;

            Console.Write("Ingrese la hora en formato 12hs: ");
            hora = int.Parse(Console.ReadLine());
            Console.Write("Ingrese los minutos: ");
            minutos = int.Parse(Console.ReadLine());
            Console.Write("Ingrese los segundos: ");
            segundos = int.Parse(Console.ReadLine());
            Console.Write("Ingrese AM o PM: ");
            indicador = Console.ReadLine();

            if (validarHora(hora) && validarMinutos(minutos) && validarSegundos(segundos) && validarIndicador(indicador))
            {
                hora12 = CrearHora12(hora, minutos, segundos, indicador);
                Console.WriteLine($"La hora ingresada es {hora12}");
                hora24 = CrearHora24(hora, minutos, segundos, indicador);
                Console.WriteLine($"La hora en formato 24 es {hora24}");

            }
            else
            {
                Console.WriteLine("Alguno de los datos fueron mal ingresados");
            }

            Console.ReadLine();


        }

        private static string CrearHora24(int hora, int minutos, int segundos, string indicador)
        {
            if (indicador.ToUpper()=="AM")
            {
                if (hora==12)
                {
                    hora = hora - 12;
                }

            }
            else
            {
                if (hora>=1 && hora<=11)
                {
                    hora = hora + 12;
                }
            }
            return
                $"{hora.ToString().PadLeft(2, '0')}:{minutos.ToString().PadLeft(2, '0')}:{segundos.ToString().PadLeft(2, '0')}";

        }

        private static string CrearHora12(int hora, int minutos, int segundos, string indicador)
        {
            return
                $"{hora.ToString().PadLeft(2, '0')}:{minutos.ToString().PadLeft(2, '0')}:{segundos.ToString().PadLeft(2, '0')} {indicador.ToUpper()}";
        }

        private static bool validarIndicador(string indicador)
        {
            return indicador.ToUpper() == "AM" || indicador.ToUpper() == "PM";
        }

        private static bool validarSegundos(int segundos)
        {
            return segundos >= 0 && segundos <= 59;
        }

        private static bool validarMinutos(int minutos)
        {
            return minutos >= 0 && minutos <= 59;
        }

        private static bool validarHora(int hora)
        {
            return hora >= 1 && hora <= 12;
        }
    }
}
