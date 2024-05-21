using System;
using UnityEngine;

[RequireComponent(typeof(ScoreCounter), typeof(ScarecrowMover), typeof(ScarecrowCollisionHandler))]
public class Scarecrow : MonoBehaviour, IAlive
{
    private ScoreCounter _scoreCounter;
    private ScarecrowMover _mover;
    private ScarecrowCollisionHandler _collisionHandler;

    public event Action HasDead;

    private void Awake()
    {
        _scoreCounter = GetComponent<ScoreCounter>();
        _mover = GetComponent<ScarecrowMover>();
        _collisionHandler = GetComponent<ScarecrowCollisionHandler>();
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

    private void Reset()
    {
        _scoreCounter.Reset();
        _mover.Reset();
    }

    public void TakeDamage()
    {
        HasDead?.Invoke();
    }
}
