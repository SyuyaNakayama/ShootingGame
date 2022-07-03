using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float spd = 0.5f;
    public GameObject particle;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.z += spd;
        transform.position = pos;
        if (pos.z >= 20) { Destroy(this.gameObject); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Instantiate(particle, transform.position, Quaternion.identity);
            other.GetComponent<Enemy>().Damage();
            Destroy(gameObject);
        }
        if (other.tag == "Boss")
        {
            other.GetComponent<BossAction>().Damage(particle, transform.position);
            Destroy(gameObject);
        }
    }
}
