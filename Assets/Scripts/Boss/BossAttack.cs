using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public Boss boss;
    public Collider[] rangeColliders, meleeColliders;
    public float radiusForFire, radiusForMelee; // flaots for attacking
    public GameObject Bullet;
    private float timer;
    public float timeInbeetweenShots; 
    
    public float dmg;
    void Start() { 
        boss = GetComponent<Boss>();

    }

    private void Update()
    {

        if (boss != null) {
            if (boss.atPoint)
            {
                Attack();
            }
            else { 
                //TODO walk
            }
        
        
        
        }
    }

    public void Attack() {
        
        rangeColliders = Physics.OverlapSphere(transform.position, radiusForFire);
        meleeColliders = Physics.OverlapSphere(transform.position, radiusForMelee);
        for (int i = 0; i < meleeColliders.Length; i++)
        {
            if (meleeColliders[i].tag == "Player")
            {
                print("melee");
                return;
            }

        }



        for (int i = 0; i < rangeColliders.Length; i++)
        {
            if (rangeColliders[i].tag == "Player")
            {
               timer += Time.deltaTime;
                //print("Fire");
                if (timer >= timeInbeetweenShots)
                {
                    timer = 0;
                    Instantiate(Bullet, transform.position, transform.rotation);
                    return;
                }
            }

        }
    }
}
