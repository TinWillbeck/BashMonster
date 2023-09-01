namespace Bash;
public class Man
{
    public int Hp;
    public int maxHp = 100;
    public int Damage;
    public int maxDamage = 20;
    public int Armor;
    public int maxArmor = 15;

    public Man()
    {
        maxHp = new Random().Next(90, 110);
        maxDamage = new Random().Next(15, 25);
        maxArmor = new Random().Next(7, 19);
        ResetHp();
        ResetStats();
    }
    public void ResetHp()
    {
        Hp = maxHp;
    }
    public void ResetStats()
    {
        Damage = maxArmor;
        Armor = maxArmor;
    }
}
