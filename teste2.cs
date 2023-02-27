// 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, 
//  faça um programa, na linguagem que desejar, que calcule e retorne:
// 	• O menor valor de faturamento ocorrido em um dia do mês;
// 	• O maior valor de faturamento ocorrido em um dia do mês;
// 	• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

// IMPORTANTE:
// 	a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
// 	b) Podem existir dias sem faturamento, como nos finais de semana e feriados. 
//  Estes dias devem ser ignorados no cálculo da média;


using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime;
using System;


class Index{

    static void Main(){
           
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\dados.json");

        var resultJson = new DataContractJsonSerializer(typeof(List<Dia>));
        var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));

        var dias = (List<Dia>)resultJson.ReadObject(ms);
        
        int  contador =0;
        double menorValor= dias[0].valor, maiorValor=0, maiorMedia =0, total= 0;

           
            for (int i = 0; i < 30; i++)
            {
                if (dias[i].valor > 0 ){
                    contador += 1;
                    total += dias[i].valor;

                }

                if (dias[i].valor > maiorValor){
                    maiorValor = dias[i].valor;
                }
                if (dias[i].valor > 0 ){
                   if(dias[i].valor < menorValor){
                        menorValor =dias[i].valor;
                   }

                }
            }

            maiorMedia = total/contador;

            int contadorDiaMedia=0;
            for (int i = 0; i < 30; i++)
            {
                if(dias[i].valor > maiorMedia){
                    contadorDiaMedia += 1;
                }
                
            }

            Console.WriteLine("Maior valor registrado "+ maiorValor.ToString("F"));
            Console.WriteLine("Menor valor registrado "+ menorValor.ToString("F"));
            Console.WriteLine("Quantidade de dias que o valor foi superior a média "+ contadorDiaMedia);
        }

  
}
  public class Dia{
            public int dia{get;set;}
            public double valor{get;set;}
    }