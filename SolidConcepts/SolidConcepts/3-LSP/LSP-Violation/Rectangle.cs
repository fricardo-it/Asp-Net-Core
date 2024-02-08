namespace SolidConcepts._3_LSP.LSP_Violation
{
    public class Rectangle
    {
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }
        public double Area { get { return Height * Width; } }
    }
}
