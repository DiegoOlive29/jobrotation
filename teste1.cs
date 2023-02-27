using System;

// 2) Dado a sequência de Fibonacci, 
//onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
//(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci 
//e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

// IMPORTANTE: 
// 	Esse número pode ser informado através de qualquer entrada de sua preferência ou pode 
//ser previamente definido no código;

class Index{

    static void Main(){
        int valor;
        Boolean result;
        Console.Write("Digite o valor a ser buscado na sequência de Fibonacci?");
        valor = int.Parse(Console.ReadLine());

        result = Fibo(valor);
        if(result == true){
            Console.Write("O valor {0} pertence a sequência.",valor);
        }else if(valor == 0){
            Console.Write("O valor 0 pertence a sequência.");

        }else if ( valor == 1){
            Console.Write("O valor 1 pertence a sequência.");

        }else{
            Console.Write("O valor {0} não pertence a sequência.",valor);
        }
     
       
    }

    public static Boolean Fibo(int n){
        int n1=0,n2=1,n3;
        for (int i = 0; i < n; i++)
        {
            n3=n1+n2;
            if(n3 == n){
                return true;
            }
            n1 = n2;
            n2 = n3;

        }
        return false;
    }

}



