using UnityEngine;

public class BossBullet : Bullet
{
    public override void HitThing(Collider other)
    {
        if (other.isTrigger) return;
        // Example: if it hits something with a "Health" component, apply damage
        PlayerHealth targetHealth = other.GetComponent<PlayerHealth>();
        if (targetHealth != null)
        {
            targetHealth.Damage(damage);
        }

        // Destroy the bullet on any collision
        Destroy(gameObject);
    }
}
