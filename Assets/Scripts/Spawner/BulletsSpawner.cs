public class BulletsSpawner : Spawner<Bullet>
{
    private BulletsSpawner _bulletsSpawner;

    private void Awake()
    {
        _bulletsSpawner = GetComponent<BulletsSpawner>();
        InitPool();
    }

    protected override Bullet Create()
    {
        Bullet bullet = base.Create();
        bullet.Init(_bulletsSpawner);

        return bullet;
    }
}