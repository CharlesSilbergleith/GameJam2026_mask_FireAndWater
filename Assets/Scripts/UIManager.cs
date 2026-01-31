using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Image ammo;
    public Image healthPlayer;
    public Image healthBoss;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (GameManager.instance == null) return;
        healthPlayer.fillAmount = GameManager.instance.playerHealth.healthPercent();
        healthBoss.fillAmount = GameManager.instance.healthBoss.healthPercent();
        ammo.fillAmount = GameManager.instance.playerAmmo.AmmoPercent();


    }
}
