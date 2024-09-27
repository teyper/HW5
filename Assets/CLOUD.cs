using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BOSS : MonoBehaviour
{
    public float speed = 0.005f;
    float startPosX;
    public float scrollLimit = 9f;

    void Start()
    {
        startPosX = transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed, 0f, 0f);

        if (transform.position.x < startPosX - scrollLimit);
        {
            transform.position = new Vector3(startPosX + scrollLimit, transform.position.y, transform.position.z);

        }
    }
}