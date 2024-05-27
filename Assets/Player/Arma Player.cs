using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaPlayer : RecursosPlayer
{
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform[] shootPoint;

    private void Update()
    {
        Shoot();  
    }

    void Shoot()
    {
        if (bullet > 0)
        {
             if (Input.GetMouseButton(0))
             {
                GameObject obj = Instantiate(Bullet);
                obj.transform.position = shootPoint[0].position;
                obj.GetComponent<BulletPlayer>().SetDirection(shootPoint[0].forward);
                bullet--;

             }
        }
       

    }
}
