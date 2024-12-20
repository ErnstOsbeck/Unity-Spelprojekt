using UnityEngine;

public class PongP1 : MonoBehaviour
{
    public float moveSpeed;
    public ParticleSystem ps;
    
    
    void Start()
    {
        ps = GetComponentInChildren<ParticleSystem>();
        ps.Pause();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ps.Play();
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
