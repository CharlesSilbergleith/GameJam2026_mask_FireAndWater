using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public List<Transform> bossPath = new List<Transform>();
    public Transform boss;
    public Health playerHealth;
    public Health healthBoss;
    public PlayerShooting playerAmmo;
    public Transform PlayerPos;
    public Collider tree;
    public Collider end;
    public Camera cam;
    public GameObject firewall;
    public InputActionAsset inputs;


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
        if (inputs["exit"].triggered)
        {
            Debug.Log("Quit pressed");
            Application.Quit();
        }
    }

    public void RegisterPoint(Transform point)//, int num)
    {
        if (!bossPath.Contains(point))
        {
            bossPath.Add(point);
            //num = Mathf.Clamp(num, 0, bossPath.Count);
            //bossPath.Insert(num, point);
            //SortPointsByDistance();
        }
    }


    void SortPointsByDistance()
    {
        if (boss == null) return;

        bossPath = bossPath.OrderBy(p => Vector3.Distance(boss.position, p.position)).ToList();
    }
    public void GameLoose() {
        print("lost");
        looseScreen();
        //TODO gameEnd
        //send to end Screen
    }
    public void GameWin()
    {
        print("Win");

        if (end != null)
            end.enabled = false;

        RenderSettings.fog = false;
        Destroy(firewall);
        cam.backgroundColor = new Color(0.1f, .4f, 1);
    }

    public void StartGame() { 
        tree.enabled = true;

    }
    public void winScreen() {
        ShowCursor();
        SceneManager.LoadScene("WinSceene");
    }
    public void looseScreen() {
        ShowCursor();
        SceneManager.LoadScene("looseScene");
    }
    public static void ShowCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public static void HideCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

}
