using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeLife : Life
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            ChangeLife(-other.gameObject.GetComponent<Damage>().GetDamage());
            Destroy(other.gameObject);
        }
    }
   
}
