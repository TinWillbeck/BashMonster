namespace Bash;
public class Fish
{
    public bool IsEdible = true;
    public int Damage = 100;
    public float Weight = 20;
    public bool Stackable = true;
    public int maxHp = 100;
    public int hp;


    public Fish()
    {
        maxHp = new Random().Next(90,110);

        ResetHp();
    }
    public void ResetHp()
    {
        hp = maxHp;
    }
}
