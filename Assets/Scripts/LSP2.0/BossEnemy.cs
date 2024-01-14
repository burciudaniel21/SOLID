using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : LSPEnemy
{
    public int magicAttackDamage = 5;

    public override void Attack()
    {
        base.Attack();
        Debug.Log($"Performing a magic attack for {magicAttackDamage}.");
    }
}
