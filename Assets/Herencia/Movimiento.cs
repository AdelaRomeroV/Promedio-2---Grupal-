using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected Transform Player;
    protected Rigidbody rb;

    private void Awake()
    {
        Initialize();
        GetPlayer();

    }

    protected virtual void Initialize()
    {
        rb = GetComponent<Rigidbody>();
    }

    void GetPlayer()
    {
      
        Player = GameObject.Find("Player").GetComponent<Transform>();
    
    }


    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {

    }
}
