using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour, IInteracteble
{
    private Rigidbody2D _rigidbody2D;
    private BulletsSpawner _bulletsSpawner;

    public Rigidbody2D Rigidbody2D { get => _rigidbody2D; private set => _rigidbody2D = value; }
    public BulletsSpawner BulletsSpawner { get => _bulletsSpawner; private set => _bulletsSpawner = value; }

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Init(BulletsSpawner bulletsSpawner)
    {
        BulletsSpawner = bulletsSpawner;
    }
}
