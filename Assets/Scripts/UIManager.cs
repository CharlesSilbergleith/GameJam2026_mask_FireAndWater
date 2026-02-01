using JetBrains.Annotations;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Slider ammo;
    public Slider healthPlayer;
    public Slider healthBoss;
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
        healthPlayer.value = GameManager.instance.playerHealth.healthPercent();
        healthBoss.value = GameManager.instance.healthBoss.healthPercent();
        ammo.value = GameManager.instance.playerAmmo.AmmoPercent();


    }
}
