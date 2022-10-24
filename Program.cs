using System;

namespace Calculadora
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("Qual calculo deseja realizar?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Porcentagem");
      Console.WriteLine("6 - Raíz Quadrada");
      Console.WriteLine("7 - Potência");
      Console.WriteLine("8 - Sair");

      Console.WriteLine("------------------");
      Console.WriteLine("Escolha uma opção: ");

      short res = short.Parse(Console.ReadLine());

      // COM IF FICA MUITA COISA ENCADEADA, O SWITCH É O MAIS PADRONIZADO A USAR
      switch (res)
      {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: Porcetagem(); break;
        case 6: RaizQuadrada(); break;
        case 7: Potencia(); break;
        case 8: System.Environment.Exit(0); break;
        default: Menu(); break;

      }

    }
    static void Soma()
    {
      Console.Clear();

      Console.WriteLine("Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 + v2;
      Console.WriteLine($"O resultado da soma é : {resultado}");
      // MESMO RESULTADO DA LINHA DE CIMA
      // Console.WriteLine("O resultado da soma é : " + resultado);
      // OU PODE FAZER DESSA FORMA
      // Console.WriteLine($"O resultado da soma é : {v1 + v2}");
      // Console.WriteLine("O resultado da soma é : " + (v1 + v2));
      Console.ReadKey();

      // RETORNA A FUNÇÃO MENU PARA O CODIGO CONTINUAR FUNCIONANDO NO TERMINAL
      Menu();
    }

    static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 - v2;
      Console.WriteLine($"O resultado da subtração é : {resultado}");
      Console.ReadKey();

      // RETORNA A FUNÇÃO MENU PARA O CODIGO CONTINUAR FUNCIONANDO NO TERMINAL
      Menu();
    }

    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 / v2;
      Console.WriteLine($"O resultado da divisão é : {resultado}");
      Console.ReadKey();

      // RETORNA A FUNÇÃO MENU PARA O CODIGO CONTINUAR FUNCIONANDO NO TERMINAL
      Menu();
    }

    static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("Primeiro valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 * v2;
      Console.WriteLine($"O resultado da multiplicação é : {resultado}");
      Console.ReadKey();

      // RETORNA A FUNÇÃO MENU PARA O CODIGO CONTINUAR FUNCIONANDO NO TERMINAL
      Menu();
    }

    static void Porcetagem()
    {
      Console.Clear();

      Console.WriteLine("Digite o primero valor:");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor da porcentagem:");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = (v1 * v2) / 100;
      Console.WriteLine($"O valor da porcetagem de {v2}% de {v1} é : {resultado}");
      Console.ReadKey();

      // RETORNA A FUNÇÃO MENU PARA O CODIGO CONTINUAR FUNCIONANDO NO TERMINAL
      Menu();
    }

    static void RaizQuadrada()
    {
      Console.Clear();

      Console.WriteLine("Digite o valor:");
      double v1 = double.Parse(Console.ReadLine());

      // Console.WriteLine("Digite o segundo valor:");
      // double v2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = Math.Sqrt(v1);
      Console.WriteLine($"O valor da raiz quadrada de {v1} é : {resultado}");
      Console.ReadKey();

      // RETORNA A FUNÇÃO MENU PARA O CODIGO CONTINUAR FUNCIONANDO NO TERMINAL
      Menu();
    }

    static void Potencia()
    {
      Console.Clear();

      Console.WriteLine("Digite o valor da base da potência:");
      double v1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Digite o valor da potência:");
      double v2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = Math.Pow(v1, v2);
      Console.WriteLine($"O valor da potência de {v1} é: {resultado}");
      Console.ReadKey();

      // RETORNA A FUNÇÃO MENU PARA O CODIGO CONTINUAR FUNCIONANDO NO TERMINAL
      Menu();
    }
  }
}