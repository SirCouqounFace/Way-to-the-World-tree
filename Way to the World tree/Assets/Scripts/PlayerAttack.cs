using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackRate = 2f;
    private float nextAttackTime = 0f;

    public Transform attackPos;
    public Animator anim;
    public LayerMask enemies;
    public float attackRange;
    public int damage = 1;

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetButton("Attack"))
            {
                anim.SetTrigger("isAttacking");
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, enemies);
                foreach (Collider2D enemy in enemiesToDamage)
                {
                    enemy.GetComponent<Enemy_Health>().TakeDamage(damage);
                }
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
