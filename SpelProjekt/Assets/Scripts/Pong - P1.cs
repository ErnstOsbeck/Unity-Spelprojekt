using UnityEngine;

public class PongP1 : MonoBehaviour
{
    public float moveSpeed;
    
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 velocity = new Vector3();
        if (Input.GetKey(KeyCode.W))
        {
            velocity.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -1;
        }

        transform.position += velocity * Time.deltaTime * moveSpeed;
    }
}
