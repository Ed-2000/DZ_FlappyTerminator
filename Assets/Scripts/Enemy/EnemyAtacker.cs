public class EnemyAtacker : Atacker
{
    private void Start()
    {
        InvokeRepeating(nameof(Shoot), 0, 2f);
    }

    public void InitBulletsSpawner(BulletsSpawner bulletsSpawner)
    {
        SetBulletSpawner(bulletsSpawner);
    }
}
