using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int dmg)
    {
        anim.SetTrigger("takeDamage");
        currentHealth -= dmg;

        if (currentHealth <= 0)
        {
            anim.SetTrigger("Die");
            Invoke("Die", 0.3f);
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
