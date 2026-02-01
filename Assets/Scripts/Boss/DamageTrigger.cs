using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
    public float damage;
    void OnTriggerEnter(Collider other)
    {
        PlayerHealth health = other.GetComponent<PlayerHealth>();
        if (health)
        {
            health.Damage(damage);
        }
    }
}