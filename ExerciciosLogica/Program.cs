using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        /* Exerciciosoma();
         ExercicioImparPar();
         ExercicioSomaigual();
         ExercicioAntecessorSucessor();
         ExercicioSalarioMinQtd();
         ExercicioReajusteCinco();
         ExercicioVerdadeiroOUFalso();
         ExercioOrdemDecrescente();
         ExercicioIMC();
        */
         PrecoProduto();


    }
    static void Exerciciosoma()
    {
        Console.WriteLine("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de C: ");
        int c = int.Parse(Console.ReadLine());
        int soma = a + b;
        Console.WriteLine("A soma de A e B é: " + soma);

        if (soma < c)
        { Console.WriteLine("A soma de A e B é menor que C"); }
        else if (soma == c)
        { Console.WriteLine("A soma de A e B é igual a C"); }
        else if (soma > c)
        { Console.WriteLine("A soma de A e B é maior que C"); }
        else
        {
            { Console.WriteLine("Erro"); }


        }



    }
    static void ExercicioImparPar()
    {
        Console.WriteLine("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número " + numero + " é par.");
        }
        else
        {
            Console.WriteLine("O número " + numero + " é ímpar.");
        }
        if (numero < 0)
        {
            Console.WriteLine("O número " + numero + " é negativo.");
        }
        else if (numero > 0)
        {
            Console.WriteLine("O número " + numero + " é positivo. ");
        }
        else
        {
            Console.WriteLine("O número é zero.");
        }
    }
    static void ExercicioSomaigual()
    {
        Console.WriteLine("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());
        int c;

        if (a == b)
        {
            c = a + b;
            Console.WriteLine("C e igual a soma de A e B pois são iguais : " + c);
        }
        else
        {
            c = a * b;
            Console.WriteLine("C e igual a multiplicação de A e B pois são diferentes: " + c);
        }
    }
    static void ExercicioAntecessorSucessor()
    {
        Console.WriteLine("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
        int antecessor = numero - 1;
        int sucessor = numero + 1;
        Console.WriteLine("O antecessor de " + numero + " é: " + antecessor);
        Console.WriteLine("O sucessor de " + numero + " é : " + sucessor);

    }
    static void ExercicioSalarioMinQtd()
    {
        Console.WriteLine("Digite o valor do salário mínimo: ");
        double salarioMinimo = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do salário do funcionário: ");
        double salarioFuncionario = double.Parse(Console.ReadLine());
        double quantidadeSalarios = salarioFuncionario / salarioMinimo;
        Console.WriteLine("O funcionário recebe " + quantidadeSalarios + " salários mínimos.");
    }

    static void ExercicioReajusteCinco()
    {
        Console.WriteLine("Digite o valor do salário atual: ");
        double salarioAtual = double.Parse(Console.ReadLine());
        double reajuste = salarioAtual * 0.05;
        double novoSalario = salarioAtual + reajuste;
        Console.WriteLine("O novo salário após o reajuste de 5% é: " + novoSalario);
    }

    static void ExercicioVerdadeiroOUFalso()
    {
        Console.WriteLine("Digite o primeiro valor (true ou false): ");
        bool valor1 = bool.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor (true ou false): ");
        bool valor2 = bool.Parse(Console.ReadLine());

        if (valor1 && valor2)
        {
            Console.WriteLine("Ambos os valores são verdadeiros.");
        }
        else if (valor1 || valor2)
        {
            Console.WriteLine("Pelo menos um dos valores é verdadeiro.");
        }
        else
        {
            Console.WriteLine("Ambos os valores são falsos.");
        }

    }
    static void ExercioOrdemDecrescente()
    {
        Console.WriteLine("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número: ");
        int num3 = int.Parse(Console.ReadLine());
        if (num1 >= num2 && num1 >= num3)
        {
            if (num2 >= num3)
            {
                Console.WriteLine($"{num1}, {num2}, {num3}");
            }
            else
            {
                Console.WriteLine($"{num1}, {num3}, {num2}");
            }
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            if (num1 >= num3)
            {
                Console.WriteLine($"{num2}, {num1}, {num3}");
            }
            else
            {
                Console.WriteLine($"{num2}, {num3}, {num1}");
            }
        }
        else
        {
            if (num1 >= num2)
            {
                Console.WriteLine($"{num3}, {num1}, {num2}");
            }
            else
            {
                Console.WriteLine($"{num3}, {num2}, {num1}");
            }
        }
    }

    static void ExercicioIMC()
    {
        Console.WriteLine("Digite seu peso (em kg): ");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua altura (em metros): ");
        double altura = double.Parse(Console.ReadLine());
        double imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é: {imc:F2}");
        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Abaixo do peso");
        }
        else if (imc < 24.9)
        {
            Console.WriteLine("Classificação: Peso normal");
        }
        else if (imc < 29.9)
        {
            Console.WriteLine("Classificação: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade");
        }
    }
    //25% a mais no preço do produto
    static void PrecoProduto()
    {
       
        var bolo = 45;
        var precoreajuste = bolo * 1.25;
        Console.WriteLine("O valor do bolo é: " + bolo);
        Console.WriteLine("O valor com reajuste de 25% é: " + precoreajuste);

        var refrigerante = 50;
        var precoreajusteRefrigerante = refrigerante * 1.25;
        Console.WriteLine("O valor do refrigerante é: " + refrigerante);
        Console.WriteLine("O valor com reajuste de 25% é: " + precoreajusteRefrigerante);


    }
    
    
    

}
   
    








    
           
        

    

