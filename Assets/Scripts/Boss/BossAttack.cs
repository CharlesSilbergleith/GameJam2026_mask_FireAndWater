using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public Boss boss;
    public Animator animator;
    public float radiusForFire, radiusForMelee; // flaots for attacking
    private float timer;
    public float timeInbeetweenShots;
    
    public float dmg;

    public BossHit hitting;
    void Start() { 
        boss = GetComponent<Boss>();
        timer = timeInbeetweenShots / 2f;
    }

    private void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            return;
        }
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

    public void Attack() 
    {
        Collider[] rangeColliders, meleeColliders;
        rangeColliders = Physics.OverlapSphere(transform.position, radiusForFire);
        meleeColliders = Physics.OverlapSphere(transform.position, radiusForMelee);
        for (int i = 0; i < meleeColliders.Length; i++)
        {
            if (meleeColliders[i].tag == "Player")
            {
                animator.SetTrigger("Punch");
                timer = timeInbeetweenShots;
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
                    animator.SetTrigger("Shoot");
                    timer = timeInbeetweenShots;
                    return;
                }
            }

        }
    }
}
