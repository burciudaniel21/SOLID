using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private new string name = "New Item Name";
    [SerializeField] private string description = "New Item Description";

    public string Name => name;
    public string Description => description;
}
