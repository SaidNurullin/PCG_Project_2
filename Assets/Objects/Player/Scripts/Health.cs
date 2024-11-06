using UnityEngine;
using UnityEngine.Events;
using System;

public class Health : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth = 3;
    public bool IsAlive { get { return currentHealth > 0; } }

    public void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            CmdDie();
        }
    }

    private void CmdDie()
    {
        Destroy(gameObject);
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

    }

}