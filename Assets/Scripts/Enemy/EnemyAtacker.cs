public class EnemyAtacker : Atacker
{
    private void Start()
    {
        InvokeRepeating(nameof(Shoot), 0, 1f);
    }
}
