using Unity.VisualScripting;
using UnityEngine;

public class PongEnemy : MonoBehaviour
{
    public float moveSpeed;
    public Transform target;
    public ParticleSystem ps;

    void Start()
    {
        target = GameObject.Find("Ball").transform;
        ps = GetComponentInChildren<ParticleSystem>();
        ps.Pause();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ps.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            target = GameObject.Find("Ball(Clone)").transform;
        }
        Vector3 velocity = new Vector3();
        if (target.position.y > transform.position.y)
        {
          velocity.y = 1;
        }

        if (target.position.y < transform.position.y)
        {
           velocity.y = -1;
        }

        transform.position += velocity * Time.deltaTime * moveSpeed;
    }
}
