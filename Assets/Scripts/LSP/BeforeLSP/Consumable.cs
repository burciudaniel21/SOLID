using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item
{
    [SerializeField] private string useText = "Drink the potion!";

    public string UseText => useText;
}
