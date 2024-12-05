// 05/12/2024 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;
    public float catchProbability = 0.5f; // Adjust this value to control the likelihood of catching

    void Update()
    {
        float step = speed * Time.deltaTime;
        if (Random.value > catchProbability)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }
    }
}