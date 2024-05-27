using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangoA : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float detectionPlayer;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float shootingInterval;
    private float timer;

    [SerializeField] private Transform player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (player != null)
        {
            float distPlayer = Vector3.Distance(transform.position, player.position);
            if (distPlayer <= detectionPlayer)
            {
                timer += Time.deltaTime;
                if (timer >= shootingInterval)
                {
                    ShootAtPlayer();
                    timer = 0f;
                }
            }
        }
    }

    private void ShootAtPlayer()
    {
        if (player != null && bullet != null && firePoint != null)
        {
            Vector3 directionToPlayer = (player.position - firePoint.position).normalized;
            Quaternion rotationToPlayer = Quaternion.LookRotation(directionToPlayer);

            Instantiate(bullet, firePoint.position, rotationToPlayer);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionPlayer);
    }
}
