using System;
using UnityEngine;

[RequireComponent(typeof(EnemyAtacker))]
public class Enemy : MonoBehaviour, IAlive
{
    private EnemyAtacker _enemyAtacker;
    private BulletsSpawner _bulletsSpawner;
    
    public event Action HasDead;

    public BulletsSpawner BulletsSpawner { get => _bulletsSpawner; private set => _bulletsSpawner = value; }

    private void Awake()
    {
        _enemyAtacker = GetComponent<EnemyAtacker>();
    }

    private void Start()
    {
        _enemyAtacker.InitBulletsSpawner(_bulletsSpawner);
    }

    public void TakeDamage()
    {
        HasDead?.Invoke();
    }

    public void Init(BulletsSpawner bulletsSpawner)
    {
        BulletsSpawner = bulletsSpawner;
    }
}