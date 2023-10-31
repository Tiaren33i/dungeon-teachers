using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boot : parametor
{
    [SerializeField] private float agro;

    private Transform target;
    void Start()
    {
        target = FindObjectOfType<Player>().transform;
    }


    private void Update()
    {
        Vector3 derect = (target.position - transform.position).normalized;
        float distansq = Vector3.Distance(transform.position, target.position);
        if (agro > distansq)
        {
            transform.position += moveSpeed * Time.deltaTime * derect;

        }
    }
}
