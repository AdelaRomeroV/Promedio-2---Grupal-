using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePlayer : Life
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet Enemy"))
        {
            ChangeLife(-other.gameObject.GetComponent<Damage>().GetDamage());
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ChangeLife(-collision.gameObject.GetComponent<Damage>().GetDamage());
            Destroy(collision.gameObject);
        }
    }
}
