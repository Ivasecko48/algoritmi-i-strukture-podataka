namespace BasicStructure
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return $"Circle with radius {radius} has an area of {CalculateArea():F2}";
        }
    }
}
