using System;

class Sistema
{
    static void Main(string[] args)
    {
        //falar o programa
        Console.WriteLine("calculadora");
        Console.WriteLine("----------------------------------------");
        
        while (true)
        {
            //pedir os numeros
            Console.Write("qual é o primero numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("qual é o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            //falar as opições
            Console.WriteLine("escolha a operação: ");
            Console.WriteLine("1 para somar");
            Console.WriteLine("2 para subtrair");
            Console.WriteLine("3 para multiplicar");
            Console.WriteLine("4 para dividir");
        
            //perguntar a operação
            Console.Write("qual a operação: ");
            int operacao = int.Parse(Console.ReadLine());

            //calcular
            if (operacao == 1)
            {
                Console.WriteLine(numero1 + numero2);
            }
            else if (operacao == 2)
            {
                Console.WriteLine(numero1 - numero2);
            }
            else if (operacao == 3)
            {
                Console.WriteLine(numero1 * numero2);
            }
            else if (operacao == 4)
            {
                Console.WriteLine(numero1 / numero2);
            }
            else
            {
                Console.WriteLine("erro");
                break;
            }
            
        }

    }
}