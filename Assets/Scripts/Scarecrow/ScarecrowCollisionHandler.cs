using System;
using UnityEngine;

public class ScarecrowCollisionHandler : MonoBehaviour
{
    public event Action<IInteracteble> CollisionDetected;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent(out IInteracteble interacteble))
            CollisionDetected?.Invoke(interacteble);
    }
}
