using UnityEngine;

public class Spike : MonoBehaviour
{
    public ParticleSystem shardsEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
        {
            if (shardsEffect != null)
            {
                Instantiate(shardsEffect, collision.transform.position, Quaternion.identity).Play();
            }

            Destroy(collision.gameObject);
        }
    }
}
