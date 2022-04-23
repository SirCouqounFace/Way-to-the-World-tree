using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAreaCheck : MonoBehaviour
{
    private Melee_Behaviour meleeParent;
    private void Awake()
    {
        meleeParent = GetComponentInParent<Melee_Behaviour>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            meleeParent.target = collider.transform;
            meleeParent.inRange = true;
            meleeParent.hotZone.SetActive(true);
        }
    }
}
