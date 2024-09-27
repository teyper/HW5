using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScroller : MonoBehaviour
{
    
    public float speed = 0.005f;
    float startPosX;
    public float scrollLimit = 9.0f;

    void Start()
    {
       
        startPosX = transform.position.x;
    }

    void Update()
    {
       
        transform.Translate(-speed, 0f, 0f);
        if (transform.position.x < startPosX - scrollLimit)
        {
            transform.position = new Vector3(startPosX + scrollLimit, transform.position.y, transform.position.z);
        }
    }
}
