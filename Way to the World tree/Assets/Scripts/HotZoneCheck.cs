using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotZoneCheck : MonoBehaviour
{
    private Melee_Behaviour meleeParent;
    private bool inRange;
    private Animator anim;
    private void Awake()
    {
        meleeParent = GetComponentInParent<Melee_Behaviour>();
        anim = GetComponentInParent<Animator>();
    }

    private void Update()
    {
        if (inRange && !anim.GetCurrentAnimatorStateInfo(0).IsName("Melee_Attack"))
        {
            meleeParent.Flip();
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            inRange = false;
            gameObject.SetActive(false);
            meleeParent.triggerArea.SetActive(true);
            meleeParent.inRange = false;
            meleeParent.SelectTarget();
        }
    }
}
