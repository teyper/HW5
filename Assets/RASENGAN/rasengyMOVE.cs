using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rasengyMOVE : MonoBehaviour
{
    [SerializeField] float Speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f); //se;f-destruct 2 sec
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Time.deltaTime, 0f, 0f);
    }
}
