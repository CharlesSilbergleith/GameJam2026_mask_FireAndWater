using UnityEngine;

public class BossPath : MonoBehaviour
{
    public int numInOrder;
    void Start()
    {
        GameManager.instance.RegisterPoint(transform,numInOrder);
    }

  
}
