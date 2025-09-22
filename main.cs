using System;

class Teste
{
    static void Main()
    {
        // declaração de variáveis
        int idade;
        string nome, sobrenome;

        // entrada: nome
        Console.WriteLine("nome.....:");
        nome = Console.ReadLine();

        // entrada: sobrenome
        Console.WriteLine("sobrenome.....:");
        sobrenome = Console.ReadLine();

        // entrada: idade
        Console.WriteLine("idade.....:");
        idade = int.Parse(Console.ReadLine());

        // regra de negócio: validação da idade
        if (idade < 18)
        {
            Console.WriteLine("Não pode entrar no evento pois tem " + idade + " anos");
        }
        else
        {
            Console.WriteLine("OK, liberado para o evento");
        }
    }
}
