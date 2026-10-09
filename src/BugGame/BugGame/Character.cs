public abstract class Character
{
    private char symbol; 
    private float exp;
    private float armor;
    private float health;
    private int actions;
    private int x,y;
    


    public float DisplayHealth()
    {
        return health;
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
    }
    public int[] DisplayPosition()
    {
        int[] array =[x,y];
        return array;
    }
    public void Move(char direction)
    {

    }
    // public bool CheckLevel() 
    // {

    // }
    public void PathFind(Character target)
    {

    }
    public abstract void SpecailMove() ;
    

}
