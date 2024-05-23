using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeFrutos : MonoBehaviour
{
    public GameObject fruit;
    public float timer;
    public float maxtimer;

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        timer+=Time.deltaTime;
            if(timer>=maxtimer)
            {
                GameObject obj= Instantiate(fruit);
                obj.transform.position = transform.position;
                timer = 0;
            }
       
    }
}
