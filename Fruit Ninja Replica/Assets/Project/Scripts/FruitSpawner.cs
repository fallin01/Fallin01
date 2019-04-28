using System.Collections;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject fruitPrefab;
    public Transform[] spawnPoints;

    public float minDelay = 0.1f;
    public float maxDelay = 0.5f;

    Transform spawnPoint;
    GameObject spawnedFruit;

    float delay;
    int spawnIndex;

    private void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    IEnumerator SpawnFruits()
    {
        while(true)
        {
            delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            spawnIndex = Random.Range(0, spawnPoints.Length);
            spawnPoint = spawnPoints[spawnIndex];

            spawnedFruit = Instantiate(fruitPrefab, spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnedFruit, 5f);
        }
    }
}