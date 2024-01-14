using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour, ICombatant, IMovable
{
    public void Attack()
    {
        Debug.Log("I can attack!");
    }

    public void Defend()
    {
        Debug.Log("I can defend!");
    }

    public void Move()
    {
        Debug.Log("I can move!");
    }
}
