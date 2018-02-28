[System.Serializable]
public class Emotion
{
    public string Name { get; set; }
    public string Intensity { get; set; }

    public Emotion() { }
    public Emotion(string name, string intensity)
    {
        Name = name;
        Intensity = intensity;
    }
}
