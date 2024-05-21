using UnityEngine;

[RequireComponent(typeof(Bullet))]
public class BulletCollisionHandler : MonoBehaviour
{
    private Bullet _bullet;
    private BulletsSpawner _bulletsSpawner;

    private void Awake()
    {
        _bullet = GetComponent<Bullet>();
    }

    private void Start()
    {
        _bulletsSpawner = _bullet.BulletsSpawner;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent(out IInteracteble interacteble))
        {

        }

        _bulletsSpawner.Release(_bullet);
    }
}
