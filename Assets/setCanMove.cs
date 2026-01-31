using JetBrains.Annotations;
using UnityEngine;

public class setCanMove : MonoBehaviour
{
    public Boss boss;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") { 
            boss.canMove=true;
        }
    }
}
