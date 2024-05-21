using System;
using UnityEngine;

[RequireComponent(typeof(EnemyAtacker))]
[RequireComponent(typeof(EnemyCollisionHendler))]
public class Enemy : MonoBehaviour, IAlive
{
    private EnemyAtacker _enemyAtacker;
    private EnemyCollisionHendler _collisionHandler;
    private EnemiesSpawner _enemiesSpawner;
    private BulletsSpawner _bulletsSpawner;

    public event Action HasDead;

    public BulletsSpawner BulletsSpawner { get => _bulletsSpawner; private set => _bulletsSpawner = value; }

    private void Awake()
    {
        _enemyAtacker = GetComponent<EnemyAtacker>();
        _collisionHandler = GetComponent<EnemyCollisionHendler>();
    }

    private void Start()
    {
        _enemyAtacker.InitBulletsSpawner(_bulletsSpawner);
    }

    private void OnEnable()
    {
        _collisionHandler.CollisionDetected += ProcessCollision;
    }

    private void OnDisable()
    {
        _collisionHandler.CollisionDetected -= ProcessCollision;
    }

    private void ProcessCollision(IInteracteble interacteble)
    {
        TakeDamage();
    }

    public void TakeDamage()
    {
        _enemiesSpawner.Release(this.GetComponent<Enemy>());
        HasDead?.Invoke();
    }

    public void Init(BulletsSpawner bulletsSpawner, EnemiesSpawner enemiesSpawner)
    {
        BulletsSpawner = bulletsSpawner;
        _enemiesSpawner = enemiesSpawner;
    }
}