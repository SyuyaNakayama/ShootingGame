using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Update()
    {
        float speed = 0.1f;
        Vector3 pos = transform.position;
        float xEdge = 34.0f;
        float zEdge = xEdge * 9.0f / 16.0f;

        if (Input.GetKey(KeyCode.C)) { speed *= 3.0f; }

        if (Input.GetKey(KeyCode.RightArrow)) { pos.x += speed; }
        if (Input.GetKey(KeyCode.LeftArrow)) { pos.x -= speed; }
        if (Input.GetKey(KeyCode.UpArrow)) { pos.z += speed; }
        if (Input.GetKey(KeyCode.DownArrow)) { pos.z -= speed; }

        if (pos.x <= -xEdge) { pos.x = -xEdge; }
        if (pos.x >= xEdge) { pos.x = xEdge; }
        if (pos.z <= -zEdge) { pos.z = -zEdge; }
        if (pos.z >= zEdge) { pos.z = zEdge; }

        transform.position = pos;
    }
}
