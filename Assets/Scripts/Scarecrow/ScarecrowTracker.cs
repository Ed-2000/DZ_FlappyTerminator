using UnityEngine;

public class ScarecrowTracker : MonoBehaviour
{
    [SerializeField] private Scarecrow _scarecrow;
    [SerializeField] private float _offsetX;

    private void LateUpdate()
    {
        var position = transform.position;
        position.x = _scarecrow.transform.position.x + _offsetX;
        transform.position = position;
    }
}
