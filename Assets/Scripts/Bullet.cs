using Unity.VisualScripting;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    public float speed;
    public float damage;
    
    void Update()
    {
        // Move the bullet forward every frame

        transform.Translate(Vector3.forward * speed * Time.deltaTime);



    }

    private void OnTriggerEnter(Collider other)
    {
        // Example: if it hits something with a "Health" component, apply damage
        Health targetHealth = other.GetComponent<Health>();
        if (targetHealth != null)
        {
            targetHealth.Damage(damage);
        }

        // Destroy the bullet on any collision
        Destroy(gameObject);
    }
}
