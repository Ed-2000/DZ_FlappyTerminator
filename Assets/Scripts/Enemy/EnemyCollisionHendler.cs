using System;
using UnityEngine;

public class EnemyCollisionHendler : MonoBehaviour
{
    public event Action<IInteracteble> CollisionDetected;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Transform collisionTransform = collision.transform;

        if (collisionTransform.TryGetComponent(out INotAlive notAlive))
            CollisionDetected?.Invoke(notAlive);
        else if (collisionTransform.TryGetComponent(out IAlive alive))
            CollisionDetected?.Invoke(alive);
    }
}
