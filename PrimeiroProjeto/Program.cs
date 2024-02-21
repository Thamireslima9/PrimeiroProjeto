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

            //Contas
            Console.WriteLine( );
            int num1, num2, soma, sub, mult, div;

            Console.WriteLine("Digite o número a: ");
                num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número b: ");
                num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;
            sub = num1 - num2;
            div = num1 / num2;
            mult = num1 * num2;

            Console.WriteLine("soma: {0} \nsubtração: {1} \ndivião: {2} \nmultiplicação: {3}", soma, sub, div,mult);









        }
    }
}
