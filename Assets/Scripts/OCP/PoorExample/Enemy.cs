using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string Type;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Type == "Goblin")
            {
                Debug.Log("The goblin attacked.");
            }            
            else if (Type == "Orc")
            {
                Debug.Log("The Orc attacked.");
            }
        };
    }
}
