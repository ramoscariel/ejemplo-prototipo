namespace EjemploUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de objetos prototipo con más atributos
            Circle originalCircle = new Circle(5.0) { Id = 1 };
            Square originalSquare = new Square(4.0) { Id = 2 };

            // Clonar objetos prototipo
            Circle clonedCircle = (Circle)originalCircle.Clone();
            Square clonedSquare = (Square)originalSquare.Clone();

            // Cambiar propiedades si es necesario
            clonedCircle.Id = 3;
            clonedCircle.Radius = 6.0; // Cambio en el radio del círculo clonado

            clonedSquare.Id = 4;
            clonedSquare.SideLength = 5.0; // Cambio en el lado del cuadrado clonado

            // Mostrar información de los objetos clonados con nuevos atributos
            Console.WriteLine($"Cloned Circle - ID: {clonedCircle.Id}, Type: {clonedCircle.Type}, Radius: {clonedCircle.Radius}");
            Console.WriteLine($"Cloned Square - ID: {clonedSquare.Id}, Type: {clonedSquare.Type}, Side Length: {clonedSquare.SideLength}");

            Console.ReadLine();
        }
    }
}