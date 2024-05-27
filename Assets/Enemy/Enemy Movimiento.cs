using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovimiento : Movimiento
{
    protected override void Move()
    {
        Transform playerTransform = Player.transform;
        Vector3 direccion = (playerTransform.position - transform.position).normalized;
        float paso = speed * Time.deltaTime;
        transform.position += direccion * paso;
    }


}
