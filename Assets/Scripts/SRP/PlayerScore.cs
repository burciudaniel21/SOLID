using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public static int score = 0;
    [SerializeField] string tag1 = "Enemy";
    [SerializeField] string tag2 = "Projectile";


    private void Start()
    {
        InvokeRepeating("UpdateScore", 0f, 5f);
    }

    public void UpdateScore()
    {
        score += 1;
        Debug.Log($"Your score is: {score}");

    }
}
