using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanew : MonoBehaviour
{
    [SerializeField] private Transform spawnArea;
    [SerializeField] private List<GameObject> enemies;
    [SerializeField] private List<EnemysCollection> enemyCollections;
    [SerializeField] private float timerSpawn;
    private float timer;
    private float totalTimer;
    private int index;
    private int collectionIndex;

    private void Update()
    {
        Progression();
        Spawn();
    }
    void Progression()
    {
        totalTimer += Time.deltaTime;
        if (totalTimer <= 10)
        {
            if (collectionIndex != 0)
            {
                index = 0;
            }
            collectionIndex = 0;
            enemies = enemyCollections[collectionIndex].Enemies;
        }
        else if (totalTimer <= 20)
        {
            if (collectionIndex != 1)
            {
                index = 0;
            }
            collectionIndex = 1;
            enemies = enemyCollections[collectionIndex].Enemies;
        }
        else if (totalTimer <= 30)
        {
            if (collectionIndex != 2)
            {
                index = 0;
            }
            collectionIndex = 2;
            enemies = enemyCollections[collectionIndex].Enemies;
        }
        else { totalTimer = 0; }
    }
    void Spawn()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            GameObject obj = Instantiate(enemies[index]);
            obj.transform.position = transform.position;
            index++;
            if (index >= enemies.Count)
            {
                index = 0;
            }
            timer = 0;
        }
    }
}
