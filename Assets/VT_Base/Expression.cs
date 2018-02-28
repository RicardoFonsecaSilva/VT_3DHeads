[System.Serializable]
public class Expression
{
    public string Name { get; set; }
    public string Intensity { get; set; }

    public Expression() { }
    public Expression(string name, string intensity)
    {
        Name = name;
        Intensity = intensity;
    }
}
