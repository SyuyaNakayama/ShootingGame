using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.RightArrow)) { pos.x += 0.01f; }
        if (Input.GetKey(KeyCode.LeftArrow)) { pos.x -= 0.01f; }
        if (Input.GetKey(KeyCode.UpArrow)) { pos.z += 0.01f; }
        if (Input.GetKey(KeyCode.DownArrow)) { pos.z -= 0.01f; }

        transform.position = pos;
    }
}
