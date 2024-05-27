using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerDetect : MonoBehaviour
{
    protected GameObject player;
    protected float radioDecteccion;
    [SerializeField] protected bool jugadorActivo = true;
    [SerializeField] protected GameObject bullet;
    [SerializeField] protected LayerMask activPlayer;

    private void Awake()
    {
        GetPlayer();
    }
    
    protected virtual void GetPlayer()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        DetectarPlayer();
    }

    protected virtual void DetectarPlayer()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radioDecteccion, activPlayer);
        jugadorActivo = false;

        foreach(Collider collider in colliders) 
        {
            if(collider.gameObject.CompareTag("Player"))
            {
                if(collider.gameObject.CompareTag("Player"))
                {
                    jugadorActivo = true;
                }
            }

        }
    }

    private void OnDrawGizmoSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radioDecteccion);
    }

}
