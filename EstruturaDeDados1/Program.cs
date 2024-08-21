internal class Program
{
    private static void Main(string[] args)
    {
        //TRABALHANDO COM LISTA (LIST)
        List<string> frutas = new List<string> { "Morango", "Manga", "Goiaba", "Uva" };


        /*Imprimir os itens na listas*/
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine(" ");

        /*Imprimir elemento na posição específica*/
        Console.WriteLine("Fruta no índice 2:" + frutas[2]);

        /*Inserir um elemento na posição específica*/
        frutas.Insert(1, "Maracujá");
        Console.WriteLine(" ");
        /*Imprimir os itens na listas*/
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine(" ");

        /*Alterar um elemento no índice específico*/
        frutas[4] = "Pêra";
        Console.WriteLine(" ");
        /*Imprimir os itens na listas*/
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine(" ");

        /*Remover elementos da lista no índice específico*/
        frutas.RemoveAt(3);
        /*Remover elementos pelo valor do conteúdo*/
        frutas.Remove("Morango");

        /*Imprimir os itens na listas*/
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine(" ");

        /*Apagar todos os elementos da lista*/
        frutas.Clear();
        /*Imprimir os itens na listas*/
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine(" ");

        // TRABALHANDO COM DICIONÁRIO DE DADOS
        Dictionary<int, string> carros = new Dictionary<int, string>();
        /*Adicionar Dados a um Dicionário*/
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        /*Imprimir um Dicionário de Dados*/
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }
        Console.WriteLine(" ");
        //TRABALHANDO COM FILA  
        /*Criar uma lista(Queue)*/
        Queue<string> filaBanco = new Queue<string>();

        /*Adicionar Elementos em uma FILA*/
        filaBanco.Enqueue("André");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("Bia");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }
        Console.WriteLine(" ");

        /*Retirar o primeiro elemento de uma fila*/
        filaBanco.Dequeue();

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }
        bool find = filaBanco.Contains("Manoel");

        if (find)
        {
            Console.WriteLine("A pessoa está na fila");
        }
        else
        {
            Console.WriteLine("A pessoa não está na fila");
        }

        Console.WriteLine(" ");

        //TRABALHANDO COM PILHA (STACK)
        /* Criando uma Pilha */
        Stack<string> livros = new Stack<string>();

        /*Adicionar elementos em uma pilha*/
        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de Neve");
        livros.Push("A princesa e o sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine(" ");

        /*Remover o Primeiro elemento da pilha*/
        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine(" ");

    }

}