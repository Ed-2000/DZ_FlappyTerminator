using UnityEngine;
using UnityEngine.Pool;

public abstract class Spawner<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T _spawnedObject;
    [SerializeField] private Transform _parent;
    [SerializeField] private int _defaultCapacity;

    private ObjectPool<T> _pool;

    public ObjectPool<T> Pool { get => _pool; set => _pool = value; }

    protected void InitPool()
    {
        _pool = new ObjectPool<T>
            (
            createFunc: () => Create(),
            actionOnGet: (obj) => ActionOnGet(obj),
            actionOnRelease: (obj) => ActionOnRelease(obj),
            actionOnDestroy: (obj) => ActionOnDestroy(obj),
            defaultCapacity: _defaultCapacity
            );
    }

    protected virtual T Create()
    {
        T poolObject = Instantiate(_spawnedObject);
        poolObject.transform.SetParent(_parent);

        return poolObject;
    }

    protected virtual void ActionOnGet(T poolObject)
    {
        Rigidbody2D rigidbody = poolObject.GetComponent<Rigidbody2D>();

        poolObject.transform.rotation = Quaternion.identity;
        rigidbody.angularVelocity = 0.0f;
        rigidbody.velocity = Vector2.zero;

        poolObject.gameObject.SetActive(true);
    }

    protected virtual void ActionOnRelease(T poolObject)
    {

        poolObject.gameObject.SetActive(false);
    }

    protected virtual void ActionOnDestroy(T poolObject)
    {
        Destroy(poolObject.gameObject);
    }

    public virtual T Get()
    {
        return _pool.Get();
    }

    public virtual void Release(T poolObject)
    {
        if (poolObject != null)
            _pool.Release(poolObject);
    }
}