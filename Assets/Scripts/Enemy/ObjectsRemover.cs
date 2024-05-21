using UnityEngine;

public class ObjectsRemover : MonoBehaviour
{
    [SerializeField] private EnemiesSpawner _enemiesSpawner;
    [SerializeField] private BulletsSpawner _bulletsSpawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
            _enemiesSpawner.Release(enemy);
        else if (collision.TryGetComponent(out Bullet bullet))
            _bulletsSpawner.Release(bullet);
    }
}