using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class bamage : MonoBehaviour
{
    [SerializeField] private float damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        bool hasHp = collision.TryGetComponent<parametor>(out var parametor);
        bool other =  !collision.CompareTag(tag);
        if (hasHp && other)
        {
            parametor.TakeDamege(damage);
        }

    }

   
}
