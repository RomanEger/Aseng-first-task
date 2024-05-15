using Game;

var list = new List<int>();

Console.WriteLine("Введите массив через пробел");

var stringArray = Console.ReadLine().Split(' ');

for (int i = 0; i < stringArray.Length; i++)
{
    if(int.TryParse(stringArray[i], out int x))
        list.Add(x);
}
var game = new GameClass();

var gameResult = game.Game(list.ToArray());

Console.WriteLine(gameResult);