using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaPlayer : RecursosPlayer
{
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform[] shootPoint;
    [SerializeField] private Armas armas;

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
                int shootpointIndex = armas.ArmaActive() ? 0 : 1; //solo son 2 armas 
                GameObject obj = Instantiate(Bullet);
                obj.transform.position = shootPoint[shootpointIndex].position;
                obj.GetComponent<BulletPlayer>().SetDirection(shootPoint[shootpointIndex].forward);
                bullet--;
            }
        }
    }
}
