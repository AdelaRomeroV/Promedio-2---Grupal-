using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecBullet : RecursosPlayer
{
    [SerializeField] private int bulletMax;

    private void Awake()
    {
        bulletMax = Random.Range(20, 30);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<ItemsMovimiento>().enabled = true;
            bullet += bulletMax;
        }
    }
}
