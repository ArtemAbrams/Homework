using Experiment;

ModifiedMethodsOfObjectClass modified = new("Ganz", "Muller", "Katze"); 
ModifiedMethodsOfObjectClass modified_5 = new("Ganz", "Muller", "Katze"); 
ModifiedMethodsOfObjectClass modified_1 = new("Ganz", "Muller", "Hund");
ModifiedMethodsOfObjectClass modified_2 = new("Ganz", "Bismark","");
ModifiedMethodsOfObjectClass modified_4 = new("Eren", "Muller", "Katze");
Console.WriteLine(modified.GetType());
Console.WriteLine();
Console.WriteLine(modified.ToString());
Console.WriteLine();
Console.WriteLine(modified.Equals(modified_5) + " " + modified.Equals(modified_1));
Console.WriteLine();
Console.WriteLine(modified_2.ToString());
Console.WriteLine();
Console.WriteLine(modified_4.Equals(modified_1));