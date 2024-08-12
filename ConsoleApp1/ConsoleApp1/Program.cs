Start:
Console.WriteLine("Pressione a tecla referente ao número do exercício: \n");
switch (Console.ReadKey().Key)
{
    case ConsoleKey.D1:
        return Exercicio1();
    case ConsoleKey.D2:
        return Exercicio2();
    case ConsoleKey.D3:
        return Exercicio3();
    case ConsoleKey.D4:
        return Exercicio4();
    case ConsoleKey.D5:
        return Exercicio5();
    default:
        goto Start;
}

int Exercicio1()
{
Exer1:
    Console.WriteLine("\nDigite um número:");
    var numero = int.TryParse(Console.ReadLine(), out int num);
    if (!numero) goto Exer1;

    var a = num % 2 == 0 ? " é par." : " é impar.";

    Console.WriteLine(num + a);

    return 0;
}
int Exercicio2()
{

    var words = new string[5];

    for (int i = 0; i < words.Length; i++)
    {
        Console.WriteLine("\nDigite um nome: \n");
        words[i] = Console.ReadLine() + "\n";
    }


    for (int i = 0; i < words.Length; i++)
    {

        for (int j = 0; j < words.Length - 1 - i; j++)
        {

            if (string.Compare(words[j], words[j + 1]) > 0)
            {
                var temp = words[j + 1];
                words[j + 1] = words[j];
                words[j] = temp;
            }
        }



    }

    Console.WriteLine("\n Nomes em ordem alfabetica: \n");

    foreach (var word in words)
    {
        Console.WriteLine(word);
    }


    return 0;
}

int Exercicio3()
{
    var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    var sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
        {
            sum += nums[i];
        }
    }

    Console.WriteLine("\nSoma dos numeros pares: {0}", sum);
    return 0;
}

int Exercicio4()
{
Exer4:
    Console.WriteLine("\nDigite um número:");
    var numero = int.TryParse(Console.ReadLine(), out int num);
    if (!numero) goto Exer4;

    Console.WriteLine("\nTabuada do {0}", num);

    for (int i = 1; i <= 10; i++)
    {
        var result = num * i;
        Console.WriteLine("\n{0} x {1} = {2}", num, i, result);
    }

    return 0;
}

int Exercicio5()
{
    Console.WriteLine("\nDigite um texto:");

    var texto = Console.ReadLine();

    var group = texto.GroupBy(x => x).ToList();

    foreach (var x in group.OrderBy(x => x.Key).ToList())
    {
        Console.WriteLine($"{x.Key}: {x.Count()} vezes");
    }


    return 0;
}
