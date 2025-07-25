using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private EnemyTarget _enemyTarget;

    public void Create()
    {
        Enemy newEnemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        newEnemy.Initialize(_enemyTarget);
    }
}
