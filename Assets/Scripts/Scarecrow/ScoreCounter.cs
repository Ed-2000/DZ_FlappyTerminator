using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int _score = 0;
    private int _startScore = 0;

    private void Add()
    {
        _score++;
    }

    public void Reset()
    {
        _score = _startScore;
    }
}
