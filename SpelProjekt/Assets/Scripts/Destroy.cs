using UnityEngine;

public class Destroy : MonoBehaviour
{
    public ParticleSystem ps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ps.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Ball"))
        {
            ps.transform.parent = null;
            ps.Play();
            SpriteRenderer.Destroy(this.gameObject);
            //Collider2D.Destroy(this.gameObject);
        }
    }
}
