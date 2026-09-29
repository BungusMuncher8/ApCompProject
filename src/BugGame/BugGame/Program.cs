// paul tokhtuev | queue example
using System.Collections.Generic;
private class Program
{
    static Queue<string> playerInput = new Queue<string>;
    static Queue<string> secondPlayerInput;

private Program()
{
    secondPlayerInput = playerInput;
}

    private Main(string[] args)
    {
        Console.WriteLine("Input amount of actions");
        
        GetInput();
    }

    static GetInput() 
    {
        int amount = 0;
        if(Int32.TryParse(Console.ReadLine(), out amount ))
        {
            SetInput(amount);
        }else {
            GetInput();
        }
        
    }
    static SetInput(int amount)
    {
        try
        {
        for(int i = 0; i < amount; i++)
        {
            playerInput.Enqueue(Console.ReadLine());
        }
        } catch
        {
            SetInput(amount);
        }
        DisplayQueue();
    }
    static DisplayQueue()
    {
        if(playerInput.Count > 0)
        {

            Console.WriteLine("All jobs: ");

         for(int i = 0; i< playerInput.Count; i++)
            {
             Console.WriteLine(playerInput[i]);
             }

            Console.WriteLine("Current Job: " + playerInput.Peek())
             ResolveQueue();
        }
        else
        {
            return;
        }
    }
    static ResolveQueue()
    {
        playerInput.Dequeue();
        DisplayQueue();
    }
}
// first in first out works for this program because we want the first input the player does to be the first inpute resolved. 
