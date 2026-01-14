namespace LAÇOS;

class Program
{
    static void Main(string[] args)
    {
        Licao10();
    }
    static void Licao1()
    {
        //CONTAGEM BASICA:
        //Crie um for que imprima os numeros de 0 a 9.

        for(int n=0;n <= 9; n++)
        {
            if(n < 9)
            {
                Console.Write(n + ", ");
            }
            else
            {
                Console.Write(n);
            }
        }
        
    }
    static void Licao2()
    {
       //Contagem regressiva:
       //Crie um for que imprima os números de 15 ate 1.

       for(int n=15;n >= 1; n--)
        {
            if(n > 1)
            {
                Console.Write(n + ", ");
            }
            else
            {
                Console.Write(n);
            }
        }
         
    } 
    static void Licao3()
    {
        //Numeros pares:
        //Imprima apenas os números pares de 0 a 30.

        for(int n=0;n <= 30; n +=2)
        {
           if(n < 30)
            {
                Console.Write(n+ ", "); 
            }
            else
            {
                Console.Write(n);
            }
        }
        Console.Write("\n");
    }
    static void Licao4()
    {
       //Sem executar o código, responda: quantas vezes o laço será executado?
       //for (int i = 2; i <= 12; i += 2)
       //Resposta = 6 repetiçoes
    }
    static void Licao5()
    {
        //Dado o array abaixo, imprima todos os valores utilizando for:
        int [] valores = {4, 9, 15, 2, 7};
        
        for(int i=0;i < valores.Length;i++)
        {
            Console.Write(valores[i]+", "); 
        }
        
    }
    static void Licao6()
    {
        //Usando o array da lição anterior, imprima apenas os valores maiores que 5.
        int [] valores = {4, 9, 15, 2, 7};

        for(int i=0;i < valores.Length;i++)
        {
            if(valores[i] > 5)
            {
                Console.Write($"{valores[i]}, ");
            }
        }
        
    }
    static void Licao7()
    {
        //Crie um for que percorra os
        // números de 1 a 20 e exiba a soma total ao final.

        int n, soma;
        soma = 0;
        

        for(n=1;n <= 20; n++)
        {
            soma = n + soma;
            if(n < 20)
            {
                Console.Write(n + ", ");
            }
            else
            {
                Console.Write(n);
            }
        }
        Console.Write("\n");
        Console.WriteLine($"Soma total = {soma}");
    }
    static void Licao9()
    {
        int n,z;

        n = 81;

        for(z=35 ;z < n; z++)
        {
            Console.Write($"{z}, ");
        }

    }
    static void Licao10()
    {
        for(int i=1;i < 100; i++)
        {
            if(i % 3 == 0 && i % 5 ==0)
            {
                Console.Write(i+", ");
            }
        }   
    }
    
}
