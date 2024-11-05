using System;
using System.ComponentModel;
using System.Dynamic;
using System.Reflection;


namespace Calculator
{
    class Program
    {
        static void Main(string[]args)
        {
            Menu();
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("--- SOMA ---");
            Console.WriteLine();
            //Entrando com o 1º valor,float.parse utilizado para converter o readLine de String para Float
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            //Entrando com o 2º valor, float.parse utilizado para converter o readLine de String para Float
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            //Somando os dois valores, utilizando o $ na exibição para poder colocar a variavel diretamente no texto utilizando {}.
            Console.WriteLine();
            float soma = v1 + v2;
            Console.WriteLine($"{v1} + {v2} = {soma}");
            Console.WriteLine();
            Console.WriteLine("0) SAIR     1)CONTINUAR");
            int SairContinuar = int.Parse(Console.ReadLine());
            if (SairContinuar == 1)
            {
                Soma();
            }
            else
            {
                Menu();
            }
        }
        static void Subtração()
        {
            //Console.Clear(); utilizado para limpar o terminal no inicio do programa
            Console.Clear();
            Console.WriteLine("--- SUBTRAÇÃO ---");
            Console.WriteLine();
            //Entrando com o 1º valor,float.parse utilizado para converter o readLine de String para Float
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            //Entrando com o 2º valor, float.parse utilizado para converter o readLine de String para Float
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            //Subtraindo os dois valores, utilizando o $ na exibição para poder colocar a variavel diretamente no texto utilizando {}.
            Console.WriteLine();
            float subtracao = v1 - v2;
            Console.WriteLine($"{v1} - {v2} = {subtracao}");
            Console.WriteLine();
            Console.WriteLine("0) SAIR     1)CONTINUAR");
            int SairContinuar = int.Parse(Console.ReadLine());
            if (SairContinuar == 1)
            {
                Subtração();
            }
            else
            {
                Menu();
            }
        }
        static void Divisao()
        {
            //Console.Clear(); utilizado para limpar o terminal no inicio do programa
            Console.Clear();
            Console.WriteLine("--- DIVISÃO ---");
            Console.WriteLine();
            //Entrando com o 1º valor,float.parse utilizado para converter o readLine de String para Float
            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            //Entrando com o 2º valor, float.parse utilizado para converter o readLine de String para Float
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            //Dividindo os dois valores, utilizando o $ na exibição para poder colocar a variavel diretamente no texto utilizando {}.
            Console.WriteLine();
            float divisao = v1 / v2;
            Console.WriteLine($"{v1} / {v2} = {divisao}");
            Console.WriteLine();
            Console.WriteLine("0) SAIR     1)CONTINUAR");
            int SairContinuar = int.Parse(Console.ReadLine());
            if (SairContinuar == 1)
            {
                Divisao();
            }
            else
            {
                Menu();
            }
        } 
        static void Multipicacao()
        {   
            //Console.Clear(); utilizado para limpar o terminal no inicio do programa
            Console.Clear();
            Console.WriteLine("--- MULTIPLICAÇÃO ---");
            Console.WriteLine();
            //Entrando com o 2º valor, float.parse utilizado para converter o readLine de String para Float
            Console.Write("Digite o 1º valor: ");
            float v1 = float.Parse(Console.ReadLine());

            //Entrando com o 2º valor, float.parse utilizado para converter o readLine de String para Float
            Console.Write("Digite o 2º valor: ");
            float v2 = float.Parse(Console.ReadLine());

            //Multiplicando os dois valores, utilizando o $ na exibição para poder colocar a variavel diretamente no texto utilizando {}.
            Console.WriteLine();
            float multplicacao = v1 * v2;
            Console.WriteLine($"{v1} x {v2} = {multplicacao}");
            Console.WriteLine();
            Console.WriteLine("0) SAIR     1)CONTINUAR");
            int SairContinuar = int.Parse(Console.ReadLine());
            if (SairContinuar == 1)
            {
                Multipicacao();
            }
            else
            {
                Menu();
            }
        }
        static void Quadrado()
        {
            Console.Clear();
            Console.WriteLine("--- EXPONENCIAÇÃO ---");
            Console.WriteLine();
            Console.Write("Digite o valor que deseja elevar: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.Write($"Digite por quanto deseja elevar {v1}: ");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var i = 1;
            var v3 = v1;
            for (i = v2-1 ; i>0; i--)
            {
                v3 = v3 * v1;
            }
            Console.WriteLine($"O resultado de {v1} elevado a {v2} é: {v3}");
            Console.WriteLine();
            Console.WriteLine("0) SAIR     1)CONTINUAR");
            int SairContinuar = int.Parse(Console.ReadLine());
            if (SairContinuar == 1)
            {
                Quadrado();
            }
            else
            {
                Menu();
            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("--- CALCULADORA ---");
            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("0) Sair   1) Soma   2) Subtração   3) Divisão   4) Multiplicação   5)Exponeciação");
            short escolha = short.Parse(Console.ReadLine());
            switch (escolha)
            {   
                case 0: System.Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtração(); break;
                case 3: Divisao(); break;
                case 4: Multipicacao(); break;
                case 5: Quadrado(); break;
                default: Menu(); break;
            }
        }
    }
}