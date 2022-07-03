using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject particle;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameObject[] enemyBulletObjects = GameObject.FindGameObjectsWithTag("EnemyBullet");
            for (int i = 0; i < enemyBulletObjects.Length; i++) { Destroy(enemyBulletObjects[i]); }
            GameObject manager = GameObject.FindGameObjectWithTag("GManager");
            manager.GetComponent<GManager>().UseBomb();
            Instantiate(particle, Vector3.zero, Quaternion.identity);
        }
    }
}
