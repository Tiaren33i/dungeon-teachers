using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boot: parametor
{
  
    private Transform target;
    void Start()
    {
        target = FindObjectOfType<Player>().transform;
    }


private void Update()
    {
      Vector3 derect = (target.position - transform.position).normalized;
        transform.position += moveSpeed * Time.deltaTime * derect;
    }
}
