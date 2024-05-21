using UnityEngine;

public abstract class Atacker : MonoBehaviour
{
    [SerializeField] private BulletsSpawner _bulletSpawner;
    [SerializeField] private Transform _startBulletTransform;
    [SerializeField] private Transform _exitBulletTransform;
    [SerializeField] private float _bulletSpeed;

    protected virtual void Shoot()
    {
        Bullet bullet = _bulletSpawner.Get();
        bullet.transform.position = _startBulletTransform.position;
        Vector2 direction = _exitBulletTransform.position - _startBulletTransform.position;
        bullet.Rigidbody2D.velocity = direction.normalized * _bulletSpeed;
    }

    public void InitBulletsSpawner(BulletsSpawner bulletsSpawner)
    {
        _bulletSpawner = bulletsSpawner;
    }
}