using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armas : MonoBehaviour
{
    [SerializeField] private GameObject[] armas;

    private void Update()
    {
        GetShoot();
    }

    protected virtual void GetShoot()
    {
        if(Input.GetKey(KeyCode.F))
        {
            armas[0].SetActive(false);
            armas[1].SetActive(true);
        }

        else
        {
            armas[0].SetActive(false);
            armas[1].SetActive(true);
        }
    }
}
