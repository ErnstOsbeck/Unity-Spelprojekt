using UnityEngine;

public class PongGoalLeft : MonoBehaviour
{
    [SerializeField]
    public int lScore = 0;
    public GameObject Ball;
    private int damage = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        IDamage damageable = other.GetComponent<IDamage>();
        if (damageable != null)
        {
            damageable.TakeDamage(damage);
        }
        lScore++;
        Instantiate(Ball);
    }
}
