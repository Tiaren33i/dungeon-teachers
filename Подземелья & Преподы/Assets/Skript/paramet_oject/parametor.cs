using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parametor : MonoBehaviour
{
    [SerializeField] protected float moveSpeed;
    [SerializeField] private float maxHelth;
   public float Helth { get; private set; }

    public bool isDed => Helth <= 0;
    private void Awake()
    {
        Helth = maxHelth;
    }
    public void TakeDamege(float damege)
    {
        Helth -= damege;
        Helth = Mathf.Clamp(Helth, 0, maxHelth);
        Debug.Log(" " + damege + " " + Helth + " " + name);
        if (isDed)
        {
            gameObject.SetActive(false);
        }

    }
}
