using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<SpawnPoints> _spawnPoints;

    private float _spawnPeriod = 2f;

    private void Start()
    {
        StartCoroutine(CountSpawnDelay(_spawnPeriod));
    }

    private IEnumerator CountSpawnDelay(float spawnTime)
    {
        var wait = new WaitForSeconds(spawnTime);

        while (enabled)
        {
            yield return wait;
            _spawnPoints[Random.Range(0, _spawnPoints.Count)].Create();
        }
    }
}
