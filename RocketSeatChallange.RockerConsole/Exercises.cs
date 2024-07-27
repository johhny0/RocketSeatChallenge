using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RocketSeatChallange.RockerConsole
{
    public static class Exercises
    {
        /// <summary>
        /// Exercicio 01 - Boas vindas personalizadas
        /// Exercicio 02 - Concatenar nome com sobrenome
        /// </summary>
        public static void ShowNameAndLastName()
        {
            Console.WriteLine("Digite seu primeiro nome:");
            var fistName = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome nome:");
            var lastname = Console.ReadLine();

            Console.WriteLine($"Bem vindo a um novo mundo, {fistName} + {lastname}!");
        }

        /// <summary>
        /// Exercicio 03 - Calculadora
        /// </summary>
        public static void Calculator()
        {

            Console.WriteLine("Calculadora.");
            Console.WriteLine("Digite o primeiro numero:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            NumberToString("         Soma dos dois numeros: ", number1 + number2);
            NumberToString("    Subtracao dos dois numeros: ", number1 - number2);
            NumberToString("Multiplicacao dos dois numeros: ", number1 * number2);
            NumberToString("      Divisao dos dois numeros: ", number2 != 0 ? number1 / number2 : 0);
            NumberToString("        Media dos dois numeros: ", (number1 + number2) / 2);

        }

        /// <summary>
        /// Exercicio 4 - Contador de caracteres
        /// </summary>
        public static void CharacterLenght()
        {
            Console.WriteLine("Digite uma frase:");
            string sentense = Console.ReadLine()!;

            Console.WriteLine($"Sua frase tem um total de {sentense.Length} caracateres");
        }

        /// <summary>
        /// Exercicio 5 - Verificar placa veicular
        /// </summary>
        public static void CheckLicensePlate()
        {
            string pattern = @"^[A-Z]{3}-?[0-9]{4}$";

            Console.WriteLine("Digite uma placa veicular:");
            string plate = Console.ReadLine()!;

            bool isValidPlate = Regex.Match(plate.ToUpper(), pattern).Success;

            Console.WriteLine($"A placa é " + (isValidPlate ? "VALIDA" : "INVALIDA"));
        }

        /// <summary>
        /// Exercicio 6 - Formatação de data
        /// </summary>
        public static void ShowTime()
        {
            Console.WriteLine("Como deseja ver a hora atual?");
            Console.WriteLine("1 - Completo");
            Console.WriteLine("2 - Apenas data");
            Console.WriteLine("3 - Apenas data (com mês por extenso)");
            Console.WriteLine("4 - Apenas hora (Formato 24h)");

            string option = Console.ReadLine()!;
            var today = DateTime.Now;
            string todayStr = string.Empty;

            switch (option)
            {
                case "1": todayStr = today.ToString("dddd, dd/MM/yyyy HH:mm:ss"); break;
                case "2": todayStr = today.ToString("dd/MM/yyyy"); break;
                case "3": todayStr = today.ToString("dd 'de' MMMM 'de' yyyy"); break;
                case "4": todayStr = today.ToString("HH:mm:ss"); break;
            }

            Console.WriteLine(todayStr);
        }

        private static void NumberToString(string msg, double number)
        {
            Console.WriteLine(msg + number.ToString("#.00"));
        }
    }

}
