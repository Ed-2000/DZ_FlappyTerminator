using UnityEngine;

public class EnemiesSpawner : Spawner<Enemy>
{
    [SerializeField] private EnemySpawnedZone _enemySpawnedZone;
    [SerializeField] private BulletsSpawner _bulletsSpawner;

    private void Awake()
    {
        InitPool();
    }

    private void Start()
    {
        InvokeRepeating(nameof(Get), 0.0f, 2.0f);
    }

    protected override Enemy Create()
    {
        Enemy enemy = base.Create();
        enemy.Init(_bulletsSpawner);

        return enemy;
    }

    public override Enemy Get()
    {
        Enemy enemy = base.Get();
        enemy.transform.position = _enemySpawnedZone.GetPosition();

        return enemy;
    }
}
