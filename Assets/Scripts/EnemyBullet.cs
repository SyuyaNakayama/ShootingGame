using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 1;
    private float time = 3;
    protected Vector3 forward = new Vector3(0, 0, 1);
    protected Quaternion forwardAxis = Quaternion.identity;
    protected Rigidbody rb;
    protected GameObject enemy;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        if (enemy != null) { forward = enemy.transform.forward; }
    }

    void Update()
    {
        rb.velocity = forwardAxis * forward * speed;
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        time -= Time.deltaTime;

        if (time <= 0) { Destroy(this.gameObject); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            GameObject manager = GameObject.FindGameObjectWithTag("GManager");
            manager.GetComponent<GManager>().PlayerDamage();
        }
    }

    public void SetCharactorObject(GameObject charactor)
    {
        this.enemy = charactor;
    }

    public void SetForwardAxis(Quaternion axis)
    {
        this.forwardAxis = axis;
    }
}
