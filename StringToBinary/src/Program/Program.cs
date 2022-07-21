List<string> list = new List<string>();

Console.Write("Enter the word: ");

string word = Console.ReadLine();

foreach(char letter in word) {
  if (letter == ' ') { Console.WriteLine(letter); }
}