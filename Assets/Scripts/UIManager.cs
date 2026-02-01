using JetBrains.Annotations;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Image ammo;
    public Image healthPlayer;
    public Image healthBoss;
    public Image blackScreen;
    public TextMeshProUGUI expo;
    private float timer;
    public float expoTime;
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
    public void Start() {
        
    }
    void Update()
    {
       
            timer += Time.deltaTime;
            if (timer > expoTime)
            {
                expo.enabled = false; ;
                blackScreen.enabled = false;
           }
        
        if (GameManager.instance == null) return;
        healthPlayer.fillAmount = GameManager.instance.playerHealth.healthPercent();
        healthBoss.fillAmount = GameManager.instance.healthBoss.healthPercent();
        ammo.fillAmount = GameManager.instance.playerAmmo.AmmoPercent();


    }
}
