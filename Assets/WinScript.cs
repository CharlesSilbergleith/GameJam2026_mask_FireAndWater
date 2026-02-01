using UnityEngine;

public class WinScript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.instance.winScreen();
        }
    }
}
