using UnityEngine;

public class BossDeath : Death
{
    public Animator animator;
    public GameObject spinnyFire;
    public override void Die()
    {

        animator.SetTrigger("Death");
        Destroy(spinnyFire);
        GetComponent<Boss>().canMove = false;
        GameManager.instance.GameWin();
        Destroy(gameObject, 4);
    }
    /*
    void OnDestroy()
    {
        GameManager.instance.GameWin();
    }
    */

}
