using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecLife : RecursosPlayer
{
    private int lifeMax;

    private void Awake()
    {
        lifeMax = Random.Range(5, 20);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<ItemsMovimiento>().enabled = true;
            life += lifeMax;
        }
    }
}
