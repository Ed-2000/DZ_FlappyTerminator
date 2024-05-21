using UnityEngine;

public class EnemySpawnedZone : MonoBehaviour
{
    private float _minX;
    private float _maxX;
    private float _minY;
    private float _maxY;

    private void Awake()
    {
        InitPisitionLimits();
    }

    public Vector2 GetPosition()
    {
        Vector2 transformPosition = transform.position;
        Vector2 position = new Vector2();

        position.x = transformPosition.x + Random.Range(_minX, _maxX);
        position.y = transformPosition.y + Random.Range(_minY, _maxY);

        return position;
    }

    private void InitPisitionLimits()
    {
        Vector2 scale = transform.localScale;
        int variableToSubtractHalf = 2;

        _maxX = scale.x / variableToSubtractHalf;
        _minX = -_maxX;
        _maxY = scale.y / variableToSubtractHalf;
        _minY = -_maxY;
    }
}
