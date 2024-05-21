using UnityEngine;

public class EnemyRemover : MonoBehaviour
{
    [SerializeField] private EnemiesSpawner _enemiesSpawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);

        if (collision.TryGetComponent(out Enemy enemy))
        {
            _enemiesSpawner.Release(enemy);
            print("RELEASE!!!");
        }
    }
}
