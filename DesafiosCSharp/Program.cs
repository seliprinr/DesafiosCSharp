Console.WriteLine("Digite sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade != 60)
{
    Console.WriteLine("Você ainda não tem o direito a tirar o cartão idoso da prefeitura");
    int anosfaltantes = 60 - idade;
    int diasfaltantes = anosfaltantes * 365;
    Console.WriteLine("Faltam ainda " + anosfaltantes + " anos para tirar seu cartão");
    Console.WriteLine("Faltam ainda " + diasfaltantes + " dias aproximadamente para tirar seu cartão");
    idade++;
    int umanomaisvelho = idade;
    diasfaltantes = (60 - umanomaisvelho) * 365;
    Console.WriteLine("Faltaria " + diasfaltantes + " dias aproximadamente para tirar seu cartão se você tivesse um ano mais velho");
} else
{
    Console.WriteLine("Você tem o direito a tirar o cartão idoso da prefeitura");
}