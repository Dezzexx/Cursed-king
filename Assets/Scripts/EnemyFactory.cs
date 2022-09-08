using UnityEngine;

[CreateAssetMenu]
public class EnemyFactory : GameObjectFactory
{
    [SerializeField] private EnemyAgent _prefab;

    public EnemyAgent Get()
    {
        EnemyAgent instance = CreateGameObjectInstance(_prefab);
        instance.OriginFactory = this;
        return instance;
    }

    public void Destroy(EnemyAgent enemy)
    {
        Destroy(enemy.gameObject);
    }
}
