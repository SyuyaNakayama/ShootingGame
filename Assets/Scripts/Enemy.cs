using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHp = 3;

    void Update()
    {
        if (enemyHp <= 0)
        {
            Destroy(this.gameObject);
            GameObject manager = GameObject.FindGameObjectWithTag("GManager");
            manager.GetComponent<GManager>().KillEnemy();
        }
    }

    public void Damage()
    {
        enemyHp--;
    }
}
