using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupActionManager : MonoBehaviour
{
    public GameObject group;

    void Update()
    {
        if (gameObject.transform.childCount == 0)
        {
            Instantiate(group);
            Destroy(gameObject);
        }
    }
}
