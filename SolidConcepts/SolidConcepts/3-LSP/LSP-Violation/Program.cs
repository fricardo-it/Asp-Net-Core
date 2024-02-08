namespace SolidConcepts._3_LSP.LSP_Violation
{
    public class Program
    {
        private static void ObtainAreaRectangle(Rectangle rectangle) 
        {
            Console.WriteLine("Rectangle Area");
            Console.WriteLine(rectangle.Height.ToString() + " * " + rectangle.Width.ToString());
            Console.WriteLine(rectangle.Area);
            Console.ReadKey();
        }

        private static void Main()
        {
            var sq = new Square()
            {
                Height = 10,
                Width = 5
            };

            ObtainAreaRectangle(sq);
        }
    }
}
