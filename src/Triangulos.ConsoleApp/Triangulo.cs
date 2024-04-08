namespace Triangulos.ConsoleApp
{
    class Triangulo
    {
        public double x, y, z;

        public string TipoDeTriangulo()
        {
            if (x > y + z || y > x + z || z > x + y)
                return "Triângulo Inválido!";
            else if (x != y && x != z && y != z)
                return "Triângulo Escaleno!";
            else if (x == y && y == z)
                return "Triângulo Equilátero!";
            else
                return "Triângulo Isósceles";
        }
    }
}
