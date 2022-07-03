using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyForwardShot : MonoBehaviour
{
    private GameObject player;
    public GameObject bullet;
    public float time = 1;
    public float delayTime = 1;
    float nowtime = 0;
    void Start()
    {
        nowtime = delayTime;
    }

    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }

        if (transform.position.z <= 20) { nowtime -= Time.deltaTime; }

        if (nowtime <= 0)
        {
            CreateShotObject(-transform.localEulerAngles.y);
            nowtime = time;
        }
    }

    private void CreateShotObject(float axis)
    {
        var direction = player.transform.position - transform.position;
        direction.y = 0;
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        GameObject bulletClone = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletObject = bulletClone.GetComponent<EnemyBullet>();
        bulletObject.SetCharactorObject(gameObject);
        bulletObject.SetForwardAxis(lookRotation * Quaternion.AngleAxis(axis, Vector3.up));
    }
}
