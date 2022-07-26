using System.Diagnostics;

namespace Experiment;

public class ModifiedMethodsOfObjectClass
{
    public string name { get; set; }
    public string surname { get; set; }
    public string YourPetIs { get; set; }

    public ModifiedMethodsOfObjectClass(string name, string surname, string YourPetIs)
    {
        this.name = name;
        this.surname = surname;
        this.YourPetIs = YourPetIs;
    }
    public override string? ToString()
    {
        return String.IsNullOrEmpty(name) & String.IsNullOrEmpty(surname) & String.IsNullOrEmpty(YourPetIs)
            ? (name + " " + surname + " pet " + YourPetIs)
            : "Valid value";
    }

    public override bool Equals(object? obj)
    {
        if (obj is ModifiedMethodsOfObjectClass modified)
        {
            return name == modified.name & surname == modified.surname & surname==modified.surname & modified.YourPetIs==YourPetIs;
        }

        return false;
    }
}