using UnityEngine;

public class PongBall : MonoBehaviour
{
    public Rigidbody2D rb;
    public int Startingspeed = 1;

    void Start()
    {
        bool isRight = UnityEngine.Random.value >= 0.5;

        float xVelocity = -1f;

        if (isRight == true)
        {
            xVelocity = 1f;
        }
        
        float yVelocity = UnityEngine.Random.Range(-1, 1f);

        rb.linearVelocity = new Vector2 (xVelocity * Startingspeed, yVelocity * Startingspeed);
    }

    
    void Update()
    {
        
    }
}
