using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    private float time = 0.1f;
    private float nowtime;
    public GameObject bullet;

    private void Start()
    {
        nowtime = time;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) { nowtime -= Time.deltaTime; }
        if (nowtime <= 0)
        {
            GetComponent<AudioSource>().Play();
            Instantiate(bullet, transform.position, Quaternion.identity);
            nowtime = time;
        }
    }
}
