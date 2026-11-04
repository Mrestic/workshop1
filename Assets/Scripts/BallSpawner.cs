using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;

    public void Spawn()
    {
        float x;
        float y; 
        
        for (int i = 0; i < 10; i++)
        {
            x = Random.Range(-6, 6);
            y = Random.Range(-1, 3);

            Instantiate(ball, new Vector2(x, y), Quaternion.identity);
        }
    }

}
