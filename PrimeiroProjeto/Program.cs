namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            string cidade;

            Console.WriteLine("Qual é o seu nome?");
                nome= Console.ReadLine();
            Console.WriteLine("Qual é a sua idade?");
                idade= int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a sua cidade?");
                cidade= Console.ReadLine();

            Console.WriteLine(  );
            Console.WriteLine("nome: {0} \nidade: {1} \ncidade: {2}",nome, idade, cidade);
        }
    }
}
