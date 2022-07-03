using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Vector3 spd = new Vector3(0, 0, -0.01f);
    void Update()
    {
        if (gameObject.tag == "Boss")
        {
            if (transform.position.z < 10)
            {
                gameObject.AddComponent<BossAction>();
                Destroy(this);
            }
        }
        if (transform.position.z < -2) { Destroy(this); }
        Vector3 pos = transform.position;
        pos += spd;
        transform.position = pos;
    }
}
