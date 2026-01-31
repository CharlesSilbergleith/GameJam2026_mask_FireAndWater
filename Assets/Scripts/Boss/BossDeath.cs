using UnityEngine;

public class BossDeath : Death
{
    public override void Die()
    {
        GameManager.instance.GameWin();
        Destroy(gameObject);
    }

   
}
