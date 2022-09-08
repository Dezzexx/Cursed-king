using UnityEngine;
using UnityEngine.AI;

// [SelectionBase] /*Remove attribute before build*/
public class EnemyAgent : MonoBehaviour
{
    [SerializeField] private Vector2 _targetPoint;
    [SerializeField] private NavMeshAgent agent;

    public EnemyFactory OriginFactory { get; set; }

    void Start()
    {
        var agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        // agent.SetDestination(_targetPoint);
    }

    public void SpawnOn(Vector2 spawnPos)
    {
        transform.position = spawnPos;
    }
}
