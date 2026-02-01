using UnityEngine;

public class HealthPuddle : MonoBehaviour
{
    public ParticleSystem particle;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().RefillHealth();
            particle.Play();
        }
    }
}