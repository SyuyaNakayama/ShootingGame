using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAction : MonoBehaviour
{
    public int hp = 500;
    private GameObject bullet;
    private EnemyFixedShot enemyFixedShot;
    private EnemyForwardShot enemyFowardShot;
    private EnemyWayShot enemyWayShot;
    int phase = 0;
    
    void Start()
    {
        bullet = Resources.Load("EnemyBullet") as GameObject;
        gameObject.AddComponent<EnemyFixedShot>();
        gameObject.AddComponent<EnemyForwardShot>();
        gameObject.AddComponent<EnemyWayShot>();
        enemyFixedShot = GetComponent<EnemyFixedShot>();
        enemyFowardShot = GetComponent<EnemyForwardShot>();
        enemyWayShot = GetComponent<EnemyWayShot>();
        enemyFixedShot.bullet = bullet;
        enemyFowardShot.bullet = bullet;
        enemyWayShot.bullet = bullet;
    }

    void Update()
    {
        if (hp >= 450)
        {
            if (phase == 0)
            {
                enemyFowardShot.enabled = false;
                enemyWayShot.enabled = false;
                enemyFixedShot.bulletWayNum = 16;
                enemyFixedShot.time = 0.2f;
                enemyFixedShot.bulletWaySpace = 180;
                enemyFixedShot.delayTime = 0.0f;
                enemyFowardShot.delayTime = 0.0f;
                enemyWayShot.delayTime = 0.0f;
                phase = 1;
            }
            enemyFixedShot.bulletWayAxis = Random.Range(0, 360);
        }
        else if (hp >= 400)
        {
            if (phase == 1)
            {
                enemyFowardShot.enabled = true;
                enemyFixedShot.bulletWayNum = 8;
                enemyFowardShot.time = 0.2f;
                phase = 2;
            }
            enemyFixedShot.bulletWayAxis = Random.Range(0, 360);
        }
        else if (hp >= 350)
        {
            if (phase == 2)
            {
                enemyFowardShot.enabled = false;
                enemyFixedShot.enabled = false;
                enemyWayShot.enabled = true;
                enemyWayShot.time = 0.2f;
                phase = 3;
            }
            enemyWayShot.bulletWayNum = Random.Range(6, 16);
            enemyWayShot.bulletWaySpace = Random.Range(30, 60);
        }
        else if (hp >= 300)
        {
            if (phase == 3)
            {
                enemyFowardShot.enabled = false;
                enemyFixedShot.enabled = true;
                enemyWayShot.enabled = false;
                enemyFixedShot.bulletWayNum = 64;
                enemyFixedShot.time = 3.0f;
                enemyFixedShot.bulletWaySpace = 60;
                enemyFixedShot.bulletWayAxis = 180;
                phase = 4;
            }
        }
        else if (hp >= 250)
        {
            if (phase == 4)
            {
                enemyFowardShot.enabled = true;
                enemyFixedShot.enabled = true;
                enemyWayShot.enabled = false;
                enemyFixedShot.bulletWayAxis = 180;
                enemyFixedShot.bulletWayNum = 12;
                enemyFixedShot.time = 1.0f;
                enemyFixedShot.bulletWaySpace = 90;
                enemyFowardShot.time = 0.1f;
                phase = 5;
            }

        }
        else if (hp >= 200)
        {
            if (phase == 5)
            {
                enemyFowardShot.enabled = false;
                enemyFixedShot.enabled = true;
                enemyWayShot.enabled = true;
                enemyFixedShot.bulletWayNum = 20;
                enemyFixedShot.time = 1.0f;
                enemyFixedShot.bulletWaySpace = 30;
                enemyWayShot.bulletWayNum = 20;
                enemyWayShot.time = 1.0f;
                enemyWayShot.bulletWaySpace = 30;
                phase = 6;
            }
            enemyFixedShot.bulletWayAxis = Random.Range(0, 360);
        }
        else if (hp >= 150)
        {
            if (phase == 6)
            {
                enemyFowardShot.enabled = false;
                enemyFixedShot.enabled = true;
                enemyWayShot.enabled = false;
                enemyFixedShot.bulletWayNum = 12;
                enemyFixedShot.time = 0.1f;
                enemyFixedShot.bulletWaySpace = 25;
                phase = 7;
            }
            enemyFixedShot.bulletWayAxis = Random.Range(0, 360);
        }
        else if (hp >= 100)
        {
            if (phase == 7)
            {
                enemyFowardShot.enabled = true;
                enemyFixedShot.enabled = true;
                enemyWayShot.enabled = false;
                enemyFixedShot.bulletWaySpace = 180;
                phase = 8;
            }
            enemyFixedShot.bulletWayNum = Random.Range(16, 32);
            enemyFixedShot.time = (float)Random.Range(0, 50) / 100.0f;
            enemyFixedShot.bulletWayAxis = Random.Range(0, 360);
            enemyFowardShot.time = (float)Random.Range(0, 50) / 100.0f;
        }
        else if (hp >= 50)
        {
            if (phase == 8)
            {
                enemyFowardShot.enabled = false;
                enemyFixedShot.enabled = true;
                enemyWayShot.enabled = true;
                enemyFixedShot.bulletWaySpace = 180;
                phase = 9;
            }
            enemyFixedShot.bulletWayNum = Random.Range(16, 32);
            enemyFixedShot.time = (float)Random.Range(0, 50) / 100.0f;
            enemyFixedShot.bulletWayAxis = Random.Range(0, 360);
            enemyWayShot.bulletWayNum = Random.Range(8, 16);
            enemyWayShot.time = (float)Random.Range(0, 100) / 100.0f;
            enemyWayShot.bulletWaySpace = Random.Range(30, 90);
        }
        else if (hp >= 0)
        {
            if (phase == 9)
            {
                enemyFowardShot.enabled = true;
                enemyFixedShot.enabled = true;
                enemyWayShot.enabled = true;
                enemyFowardShot.time = 0.25f;
                enemyFixedShot.time = 0.25f;
                enemyFixedShot.bulletWaySpace = 180;
                enemyFixedShot.bulletWayNum = 48;
                enemyWayShot.time = 0.25f;
                phase = 10;
            }
            enemyWayShot.bulletWayNum = Random.Range(12, 24);
            enemyWayShot.bulletWaySpace = Random.Range(20, 60);
        }
        else
        {
            Destroy(gameObject);
            GameObject manager = GameObject.FindGameObjectWithTag("GManager");
            manager.GetComponent<GManager>().GameClear();
            GameObject[] enemyBullet = GameObject.FindGameObjectsWithTag("EnemyBullet");
            for (int i = 0; i < enemyBullet.Length; i++)
            {
                Destroy(enemyBullet[i]);
            }
        }
    }

    public void Damage(GameObject particle, Vector3 bulletPosition)
    {
        Instantiate(particle, bulletPosition, Quaternion.identity);
        hp--;
        GetComponent<AudioSource>().Play();
    }
}
