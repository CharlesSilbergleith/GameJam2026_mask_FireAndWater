using UnityEngine;

public class BossPath : MonoBehaviour
{
    public int numInOrder;
    void Update()
    {
        if (GameManager.instance.bossPath.Count < numInOrder) return;
        GameManager.instance.RegisterPoint(transform);//, numInOrder);
        Destroy(this);
    }

}