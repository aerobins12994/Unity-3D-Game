using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class monsterHealth : MonoBehaviour {

    public int startingHealth = 5;
    public int currentHealth;
    public Slider healthSlider;                                 // Reference to the UI's health bar.
    public GameObject HealthBar;
    public GameObject monster;

    void Awake()
    {
        // Set the initial health of the player.
        currentHealth = startingHealth;
    }

    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        healthSlider.value = currentHealth;
        if(currentHealth <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
       monster.SetActive(false);
       HealthBar.SetActive(false);
    }
}
