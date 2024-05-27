using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private Transform player;
    private Rigidbody rb;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        Direccion();
        Invoke("Destruir", 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destruir();
        }
    }

    private void Direccion()
    {
        Vector3 dir = player.position - transform.position;
        Vector3 movimiento = dir.normalized * speed;
        rb.AddForce(movimiento, ForceMode.VelocityChange);
    }

    void Destruir() { Destroy(gameObject); }

}
