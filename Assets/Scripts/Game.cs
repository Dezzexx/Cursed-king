using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private TileBoard _tileBoard;
    [SerializeField] EnemyFactory _enemyFactory;
    [SerializeField, Range(0.1f, 4f)] private float _spawnSpeed;
    [SerializeField] private int _wave;

    private float _spawnProgress;
    private int _enemyCounter;

    private void Update()
    {
        _spawnProgress += _spawnSpeed * Time.deltaTime;

        while ((_spawnProgress >= 1f) && (_enemyCounter <= _wave))
        {
            _spawnProgress -= 1f;
            SpawnEnemy();
        }

    }

    private void SpawnEnemy()
    {
        Vector2 _spawnPoint = _tileBoard.GetSpawnPoint(Random.Range(0, _tileBoard.SpawnPointCount));
        EnemyAgent enemy = _enemyFactory.Get();
        enemy.SpawnOn(_spawnPoint);
        _enemyCounter++;
    }
}
