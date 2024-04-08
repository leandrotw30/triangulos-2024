namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores dos lados de um triângulo, para descobrir qual tipo ele é: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());

            Triangulo criarTriangulo = new Triangulo();

            criarTriangulo.x = x;
            criarTriangulo.y = y;
            criarTriangulo.z = z;

            string tipoDeTriangulo = criarTriangulo.TipoDeTriangulo();

            Console.WriteLine(tipoDeTriangulo);
        }
    }
}
