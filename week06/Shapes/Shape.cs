public class Shape
{
    //Color
    public string Color { get; set; }

    // Constructor to set the color when the shape is created
    public Shape(string color)
    {
        Color = color;
    }
    public virtual double GetArea()
    {
        return 0; 
    }
}
