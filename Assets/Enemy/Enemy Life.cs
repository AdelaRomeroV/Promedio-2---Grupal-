using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyLife : Life
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            ChangeLife(-other.gameObject.GetComponent<Damage>().GetDamage());
            Destroy(other.gameObject);
        }
        
    }
}
