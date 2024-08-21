internal class Program
{
    private static void Main(string[] args)
    {
        //TRABALHANDO COM LISTA (LIST)
        List<string> frutas = new List<string> { "Morango", "Manga", "Goiaba", "Uva" };


        //Imprimir os itens na listas
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine(" ");A

        //Imprimir elemento na posição específica
        Console.WriteLine("Fruta no índice 2:" + frutas[2]);

        //Inserir um elemento na posição específica
        frutas.Insert(1, "Maracujá");
        Console.WriteLine(" ");
        //Imprimir os itens na listas
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine(" ");

        //Alterar um elemento no índice específico
        frutas[4] = "Pêra";
        Console.WriteLine(" ");
        //Imprimir os itens na listas
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine(" ");

        //Remover elementos da lista no índice específico
        frutas.RemoveAt(3);
        //Remover elementos pelo valor do conteúdo
        frutas.Remove("Morango");

        //Imprimir os itens na listas
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine(" ");

        //Apagar todos os elementos da lista
        frutas.Clear();
        //Imprimir os itens na listas
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);
        Console.WriteLine(" ");


    }
}