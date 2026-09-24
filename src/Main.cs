//Mock because I can't create real project on mac
using System.IO; // need for reading and writing to text files need for later features

private class Main 

{
  static Player player = new Player(); 


static void EntryWelcome()
{
string name = Console.ReadLine();
  player.SetName(name);
}
  
  static void Main(string[] args)
    {
           // player1.SpecailMove("YIPPEE");
    
        Console.WriteLine("Welcome to Bug Game");
        EntryWelcome();

    }

}
