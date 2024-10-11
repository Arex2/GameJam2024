using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    ParticleSystem _particleSystem;
    Rigidbody2D rb;
    AudioSource audioSource;

    static public int damage = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 3f * rb.velocity.normalized.x));
        //Debug.Log(rb.velocity.normalized.x);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //find enemy
        if(collision.gameObject.CompareTag("Enemy"))
        {
            //collision.gameObject.GetComponent<EnemyMovement>.TakeDamage(damage);
        }
        audioSource.Play(0);
        DestroyProjectile();
    }

    void DestroyProjectile()
    {
        var rotationAtImpact = this.transform.rotation;
        Instantiate(_particleSystem, transform.position, transform.rotation);// Quaternion.Inverse(rotationAtImpact));
        Destroy(this.gameObject);
    }
}
