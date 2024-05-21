using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Scarecrow _scarecrow;

    private void OnEnable()
    {
        _scarecrow.HasDead += GameOver;
    }

    private void OnDisable()
    {
        _scarecrow.HasDead -= GameOver;
    }

    private void GameOver()
    {
        Time.timeScale = 0;
    }
}