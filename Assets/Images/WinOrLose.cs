using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 05/12/2024 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product

// 05/12/2024 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product

using UnityEngine;
using UnityEngine.UI;

using UnityEngine;

public class PlayerInteractionHandler : MonoBehaviour
{
    public GameObject treasures; // Assign the treasures GameObject here
    public GameObject enemy; // Assign the enemy GameObject here

    public float detectionRadius = 2.0f; // Adjust for treasures
    public float enemyDetectionRadius = 2.0f; // Adjust for enemy

    void Update()
    {
        // Check distance between player and treasures
        float treasureDistance = Vector3.Distance(transform.position, treasures.transform.position);
        if (treasureDistance <= detectionRadius)
        {
            Debug.Log("You Win!");
            WinGame();
        }

        // Check distance between player and enemy
        float enemyDistance = Vector3.Distance(transform.position, enemy.transform.position);
        if (enemyDistance <= enemyDetectionRadius)
        {
          //  Debug.Log("Game Over!");
            GameOver();
        }
    }

    void WinGame()
    {
       // Debug.Log("Player Wins!");
        Time.timeScale = 0; // Stops the game
    }

    void GameOver()
    {
        //Debug.Log("Player Lost!");
        Time.timeScale = 0; // Stops the game
    }

    // Optional: Visualize detection areas for debugging
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRadius); // Treasures radius
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, enemyDetectionRadius); // Enemy radius
    }
}
