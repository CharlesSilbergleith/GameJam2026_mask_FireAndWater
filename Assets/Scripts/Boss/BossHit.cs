using UnityEngine;
using UnityEngine.UIElements;

public class BossHit : MonoBehaviour
{
    public Transform bulletSpawnPos;
    public Transform punchPos;
    public float punchRadius;
    public float punchDamage;
    public GameObject Bullet;
    public void Shoot()
    {
        Instantiate(Bullet, bulletSpawnPos.position, bulletSpawnPos.rotation);
    }
    public void Punch()
    {
        Collider[] cols = Physics.OverlapSphere(punchPos.position, punchRadius);
        for (int i = 0; i < cols.Length; i++)
        {
            Health h = cols[i].GetComponent<Health>();
            if (h) h.Damage(punchDamage);
        }
    }
}
