using UnityEngine;

public class Goblin : MonoBehaviour,  IEnemy
{
    public void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("The goblin attacked.");
        };
    }

    void Update()
    {
        Attack();
    }
}
