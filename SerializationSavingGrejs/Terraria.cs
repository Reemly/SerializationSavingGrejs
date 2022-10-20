using System.IO;
using System.Text.Json;

Character Terrarian = new Character();

Terrarian.Health = 100;
Terrarian.EyeColor = "";
Terrarian.JumpHeight = 2;

Console.WriteLine("");

//DU MÅSTE SKRIVA ELLER GÖRA SÅ ATT ANVÄNDAREN KAN SPARA DERAS EGNA VÄRDEN!!

string test = JsonSerializer.Serialize<Character>(Terrarian);

File.WriteAllText("char.json", test);

Console.WriteLine(test);

Console.ReadLine();

