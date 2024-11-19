using UnityEngine;

public class PongGoalLeft : MonoBehaviour
{
    [SerializeField]
    private int score = 0;
    public GameObject Ball;
    private int damage = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        IDamage damageable = other.GetComponent<IDamage>();
        if (damageable != null)
        {
            damageable.TakeDamage(damage);
        }
        score++;
        Instantiate(Ball);
    }
}
