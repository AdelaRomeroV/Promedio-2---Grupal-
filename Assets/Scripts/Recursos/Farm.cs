using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour
{
    public float time;
    public GameObject prefab;
    public Transform startPoint;
    void Start()
    {
        StartCoroutine(PlantaCrece());
    }
    private IEnumerator PlantaCrece()
    {
        if (startPoint.childCount == 0) 
        {
            Instantiate(prefab, startPoint);
        }
        yield return new WaitForSeconds(time);
        StartCoroutine(PlantaCrece());
    }
}
