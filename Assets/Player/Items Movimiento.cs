using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsMovimiento : MonoBehaviour
{
    private GameObject Player;
    private float timer;

    private void Awake()
    {
        Player = GameObject.FindWithTag("Estrutura Central");
    }

    private void Update()
    {
        timer += Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 2 * timer);
    }
}
