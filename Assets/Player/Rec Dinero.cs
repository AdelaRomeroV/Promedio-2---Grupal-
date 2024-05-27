using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecDinero : RecursosPlayer
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dinero += Random.Range(5, 30);
            gameObject.GetComponent<ItemsMovimiento>().enabled = true;
        }
    }
}
