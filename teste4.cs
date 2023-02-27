using System;
// 5) Escreva um programa que inverta os caracteres de um string.

// IMPORTANTE:
// 	a) Essa string pode ser informada através de qualquer entrada de 
//  sua preferência ou pode ser previamente definida no código;
// 	b) Evite usar funções prontas, como, por exemplo, reverse;
class Index{

    static void Main(){
        
        string str,invert="";
        
        Console.Write("Digite o valor a string a ser invertida:");
        
        str = Console.ReadLine();
        
        for (int i = str.Length; i > 0; i--)
        {
            invert += str[i-1];

        }


        Console.Write(invert);
       
    }

    

}