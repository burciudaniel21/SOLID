using UnityEngine;

public interface IWeapon
{
    void Shoot();
}

public class Player
{
    private IWeapon weapon;

    public Player(IWeapon weapon)
    {
        this.weapon = weapon; // Player depends on abstraction (IWeapon)
    }

    public void Shoot()
    {
        weapon.Shoot();
    }
}

public class Gun : IWeapon
{
    public void Shoot()
    {
        Debug.Log("Pew pew");
    }
}