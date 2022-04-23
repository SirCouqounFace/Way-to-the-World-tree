using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public Animator anim;

    public HealtBar healtBar;

    void Start()
    {
        currentHealth = maxHealth;
        healtBar.SetMaxHealth(maxHealth);
    }
    public void TakeDamage(int dmg)
    {
        anim.SetTrigger("takeDamage");
        currentHealth -= dmg;
        healtBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        anim.SetTrigger("Die");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
