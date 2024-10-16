using UnityEngine;

public class PongP1 : MonoBehaviour
{
    public float moveSpeed;
    
    void Start()
    {
        
    }

    void Update()
    {
        bool isPressingUp = Input.GetKeyUp(KeyCode.W);
        bool isPressingDown = Input.GetKeyUp(KeyCode.S);

        if (isPressingUp)
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }
        if (isPressingDown)
        {
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        }
    }
}
