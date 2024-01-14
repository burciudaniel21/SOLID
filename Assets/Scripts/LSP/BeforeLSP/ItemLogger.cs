using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLogger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var item = GetComponent<Item>();

        if (item == null) { return; }

        if(item is Consumable)
        {
            Debug.Log($"{item.Name} : You can drink to potion to replenish your HP. Description: {item.Description}.");
        }
        else if(item is Weapon)
        {
            Debug.Log($"{item.Name} : Weapons are for attacking. Description: {item.Description}.");
        }
    }

}
