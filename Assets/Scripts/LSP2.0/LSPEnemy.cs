using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSPEnemy : MonoBehaviour
{
    public int basicAttackDamage = 3;

    private void Start()
    {
        Attack();
    }
    public virtual void Attack()
    {
        Debug.Log($"Performing a basic attack for {basicAttackDamage} damage.");
    }
}
