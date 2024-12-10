using Unity.Mathematics;
using UnityEngine;

public class Explode : MonoBehaviour 
    {
        public ParticleSystem explosion;

        public void explode(Vector3 position)
        {
            Instantiate(explosion, position, quaternion.identity);
        }
    }
