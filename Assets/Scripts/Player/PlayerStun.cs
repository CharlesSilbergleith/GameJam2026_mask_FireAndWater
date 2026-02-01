using UnityEngine;

public class PlayerStun : Death
{
    public Animator playerAnim;
    public float stunDuration;
   public float isStunned;
    private void Update()
    {
        if(playerAnim)
            playerAnim.SetBool("Stun", isStunned > 0);
        if (isStunned > 0)
        {
            isStunned -= Time.deltaTime;
        }
    }
    public override void Die()
    {
        isStunned = stunDuration;
    }
    public bool getIsStunned()
    {
        return isStunned > 0;
    }

}
    // Start is called once before the first execution of Update after the MonoBehaviour is created



