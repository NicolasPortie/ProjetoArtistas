string mensagemDeBoasVindas = "Bem-vindo ao Artista Avaliações";
Dictionary<string, List<int>> artistasRegistrados = new Dictionary<string, List<int>>();
artistasRegistrados.Add("Khalid", new List<int> { 10, 9, 8 });
artistasRegistrados.Add("Post Malone", new List<int>());

void ExibirOpcoesDoMenu()
{
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("\nDigite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para mostrar todos os artistas");
    Console.WriteLine("Digite 3 para avaliar um artista");
    Console.WriteLine("Digite 4 para exibir a média de um artista");
    Console.WriteLine("Digite 5 para remover um artista");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarArtista();
            break;
        case 2:
            MostrarArtistasRegistrados();
            break;
        case 3:
            AvaliarUmArtista();
            break;
        case 4:
            ExibirMediaDeUmArtista();
            break;
        case 5:
            RemoverArtista();
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarArtista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Artistas");
    Console.Write("Digite o nome do artista que deseja registrar: ");
    string nomeDoArtista = Console.ReadLine()!;
    artistasRegistrados.Add(nomeDoArtista, new List<int>());
    Console.WriteLine($"O artista {nomeDoArtista} foi registrado com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarArtistasRegistrados()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todos os artistas registrados na nossa aplicação");

    foreach (string artista in artistasRegistrados.Keys)
    {
        Console.WriteLine($"Artista: {artista}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmArtista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Artista");
    Console.Write("Digite o nome do artista que deseja avaliar: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (artistasRegistrados.ContainsKey(nomeDoArtista))
    {
        Console.Write($"Qual a nota que o artista {nomeDoArtista} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        artistasRegistrados[nomeDoArtista].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o artista {nomeDoArtista}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nO artista {nomeDoArtista} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaDeUmArtista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média do artista");
    Console.Write("Digite o nome do artista que deseja exibir a média: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (artistasRegistrados.ContainsKey(nomeDoArtista))
    {
        List<int> notasDoArtista = artistasRegistrados[nomeDoArtista];
        if (notasDoArtista.Count > 0)
        {
            double media = notasDoArtista.Average();
            Console.WriteLine($"\nA média do artista {nomeDoArtista} é {media:F2}.");
        }
        else
        {
            Console.WriteLine($"\nO artista {nomeDoArtista} ainda não possui avaliações.");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nO artista {nomeDoArtista} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void RemoverArtista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Remover Artista");
    Console.Write("Digite o nome do artista que deseja remover: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (artistasRegistrados.ContainsKey(nomeDoArtista))
    {
        artistasRegistrados.Remove(nomeDoArtista);
        Console.WriteLine($"\nO artista {nomeDoArtista} foi removido com sucesso.");
    }
    else
    {
        Console.WriteLine($"\nO artista {nomeDoArtista} não foi encontrado!");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();
