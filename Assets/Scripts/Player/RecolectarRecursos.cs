using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectarRecursos : MonoBehaviour
{
    public int sandias;
    public int trigo;
    public int huesos;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Sandia":
                sandias++;
                break;
            case "Trigo":
                trigo++;
                break;
            case "Hueso":
                huesos++;
                break;
            default:
                break;
        }
    }
}
