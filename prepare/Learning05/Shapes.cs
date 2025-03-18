public abstract class Shapes
{
    private string _color;
    public List<Square> _square = new List<Square>();

    public Shapes(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}