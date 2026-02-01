using System.Collections.Generic;
using System.Linq;
using UnityEngine;

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
        //TODO gameEnd
        //send to end Screen
    }
    public void GameWin()
    {
        print("lost");
        end.enabled = false;
        RenderSettings.fog = false;
        //TODO gameEnd
        //send to end Screen
    }
    public void StartGame() { 
        tree.enabled = true;

    }
}
