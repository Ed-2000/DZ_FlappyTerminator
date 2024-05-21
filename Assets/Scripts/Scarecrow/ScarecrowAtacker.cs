using UnityEngine;

public class ScarecrowAtacker : Atacker
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }
}
