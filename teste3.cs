// 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

// 	SP – R$67.836,43
// 	RJ – R$36.678,66
// 	MG – R$29.229,88
// 	ES – R$27.165,48
// 	Outros – R$19.849,53

// Escreva um programa na linguagem que desejar onde calcule o percentual de 
//representação que cada estado teve dentro do valor total mensal da distribuidora.



using System;

class Index{

 static void Main(){
        
        double SP= 67836.43 , RJ = 36678.66, MG=29229.88 , ES=27165.48 , Outros =19849.53 ;

        double PgSp, PgRj,PgMG,PgEs,PgOutros;

        double total  = SP + RJ + MG + ES + Outros;

        PgSp = SP*100/total;
        PgRj = RJ*100/total;
        PgMG = MG*100/total;
        PgEs = ES*100/total;
        PgOutros = Outros*100/total;

        
        Console.WriteLine("SP : "+ PgSp.ToString("F"));
        Console.WriteLine("RJ : "+PgRj.ToString("F"));
        Console.WriteLine("MG : "+PgMG.ToString("F"));
        Console.WriteLine("ES : "+PgEs.ToString("F"));
        Console.WriteLine("Outros : "+PgOutros.ToString("F"));
        double  totalPG = PgSp+PgRj+PgMG+PgEs+PgOutros;


 
       
    }
}