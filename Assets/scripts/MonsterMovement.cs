﻿using UnityEngine;
using System.Collections;

public class MonsterMovement : MonoBehaviour
{
    public Transform player;               // Find the player
    PlayerHealth playerHealth;      // Player's remaining HP
    // EnemyHealth enemyHealth;        // Remaining Monster HP
    NavMeshAgent nav;               // Reference to the nav mesh agent.
    Animator anim;                  // Reference to the animator component.

    void Awake()
    {
       playerHealth = player.GetComponent<PlayerHealth>();
       // enemyHealth = GetComponent<EnemyHealth>();
       nav = GetComponent<NavMeshAgent>(); //References to the mesh component
       anim = GetComponent<Animator>();
    }

    void Update()
    {
        // If the player has been spotted by the monster
        if ( anim.GetBool("PlayerSpotted") )
        {
            // If the enemy and the player have health left...
            if (/* enemyHealth.currentHealth > 0 && */ playerHealth.currentHealth > 0)
            {
                // Send the monster to the player
                nav.SetDestination(player.position);
            }
            else
            {
                // ... disable the nav mesh agent.
                nav.enabled = false;
            }
        }
    }
}