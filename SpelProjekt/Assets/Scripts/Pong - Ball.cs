using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PongBall : PongP1, IDamage
{
    public Rigidbody2D rb;
    public int Startingspeed = 1;
    public PongP1 Player;
    public Vector2 playerPosition;
    
    

    public void TakeDamage(int damage)
    {
        Destroy(gameObject);
    }
    


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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag != "Player" && collision.collider.tag != "Enemy")
            return;
        Debug.Log("bounce");
        Vector2 playerPosition = collision.collider.transform.position;
        Vector2 bounceDirection = playerPosition - rb.position;
        float bounceAngle = Mathf.Atan2(bounceDirection.y, bounceDirection.x) * Mathf.Rad2Deg - 90f;
        float xVelocity = math.cos(bounceAngle);
        float yVelocity = math.sin(-bounceAngle);
        rb.linearVelocity = new Vector2(xVelocity * Startingspeed, yVelocity * Startingspeed);
    }
    void Update()
    {
        
    }
}
