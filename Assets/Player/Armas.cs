using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armas : MonoBehaviour
{
    [SerializeField] private GameObject[] armas;
    private bool armaActiva = true;

    private void Start()
    {
        if (armas.Length >= 2)
        {
            armas[0].SetActive(true);
            armas[1].SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && armas.Length >= 2) 
        { 
            armaActiva = !armaActiva;

            armas[0].SetActive(armaActiva);
            armas[1].SetActive(!armaActiva);

        }
    }
}
