using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmEs : MonoBehaviour
{
    public float time;
    public GameObject prefab;
    public Transform startPoint;
    public bool construccionOn = false;

    void Start()
    {
        StartCoroutine(PlantaCrece());
    }
    private IEnumerator PlantaCrece()
    {
        if (startPoint.childCount == 0 && construccionOn)
        {
            Instantiate(prefab, startPoint);
        }
        yield return new WaitForSeconds(time);
        StartCoroutine(PlantaCrece());
    }
}
