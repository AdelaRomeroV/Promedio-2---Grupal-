using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Creditos : MonoBehaviour
{
    public string[] names;
    public TextMeshProUGUI WriteNames;

    void Start()
    {
        StartCoroutine(ChangeNames());
    }

    public IEnumerator ChangeNames()
    {
        foreach(string text in names)
        {
            WriteNames.text = text;
            yield return new WaitForSeconds(5);

        }

    }
}