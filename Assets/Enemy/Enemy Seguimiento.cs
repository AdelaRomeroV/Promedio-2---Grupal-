using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySeguimiento : Movimiento
{
    protected override void Move()
    {
        Vector3 direction = new Vector3(Player.position.x - transform.position.x, 0, Player.position.z - transform.position.z);
        rb.velocity = direction.normalized * speed * Time.deltaTime;
    }
}
