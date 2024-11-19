using Unity.VisualScripting;
using UnityEngine;

public class PongEnemy : MonoBehaviour
{
    public float moveSpeed;
    public Transform target;
    

    void Start()
    {
        target = GameObject.Find("Ball").transform;
    }

    // Update is called once per frame
    void Update()
    {
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
