using System.IO;
using System.Text.Json;

Character Terrarian = new Character();

Terrarian.Health = 100;
Terrarian.EyeColor = "";
Terrarian.JumpHeight = 2;


Console.WriteLine("Write health amount:");
Console.WriteLine("Write your characters eyecolor:");
Console.WriteLine("Write jump height:");
string health = Console.ReadLine();
string eyecolor = Console.ReadLine();
string jumpheight = Console.ReadLine();



string test = JsonSerializer.Serialize<Character>(Terrarian);

File.WriteAllText("char.json", test);

Console.WriteLine(test);

Console.ReadLine();

