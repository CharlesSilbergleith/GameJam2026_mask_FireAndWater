using System.Runtime.InteropServices;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float speed;

    private int pathNum;

    private float timer;
    public float timeToNextPoint;
    public bool atPoint;

    public float turnSpeed;
    public bool canMove= false;

    void Update()
    {
        if (canMove)
        {

            //check to see if theings exsits
            if (GameManager.instance == null) return;
            if (GameManager.instance.bossPath.Count == 0) return;
            if (pathNum >= GameManager.instance.bossPath.Count) return;

            Transform targetPoint = GameManager.instance.bossPath[pathNum];
            Vector3 target = targetPoint.position;

            if (!atPoint)
            {
                Vector3 direction = targetPoint.position - transform.position;
                transform.rotation = Quaternion.LookRotation(direction);
            }
            else
            {
                Transform playerTransform = GameManager.instance.PlayerPos;
                Vector3 direction = playerTransform.position - transform.position;
                transform.rotation = Quaternion.LookRotation(direction);
            }

            //make vars

            if (GameManager.instance.bossPath.Count != pathNum)
            {
                if (Vector3.Distance(transform.position, target) < 0.1f)
                {// If close enough → go to next point
                    timer += Time.deltaTime;
                    atPoint = true;
                    if (timer >= timeToNextPoint)
                    {
                        NextPos();
                        timer = 0;
                    }
                }
                else
                {
                    atPoint = false;
                    transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
                }

            }


        }
    }

    public void NextPos()
    {
        pathNum++;

        // Optional: stop at last point
        if (pathNum >= GameManager.instance.bossPath.Count)
        {
            GameManager.instance.GameLoose();

        }
    }
}
