using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour, ICombatant
{
    public void Attack()
    {
        Debug.Log("I can attack!");
    }

    public void Defend()
    {
        Debug.Log("I can defend!");
    }
}
