using UnityEngine;

public class BulletPlayer : Bullet
{
    public float lifetime;     // How long before it destroys itself
  
    void Start()
    {
        // Automatically destroy the bullet after 'lifetime' seconds

        Destroy(gameObject, lifetime);
    }

}
