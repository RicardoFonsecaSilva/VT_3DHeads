﻿[System.Serializable]
public class Tutor
{
    public string Name { get; set; }

    public Tutor() { }
    public Tutor(string name)
    {
        Name = name;
    }
}