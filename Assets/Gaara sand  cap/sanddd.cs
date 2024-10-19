using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanddd : MonoBehaviour
{
    [SerializeField] float LifeSpan = 3f;
    [SerializeField] float Speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        //self destruct after 5 secs
        Destroy(gameObject, LifeSpan);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Speed * Time.deltaTime,0f,0f);  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Kitty:I hit a Rasengan!" + collision.tag);
        //Destroy(gameObject, LifeSpan);
        if (collision.tag == "player")
        {

        }

        if (collision.tag == "rasengan")
        {
            AudioSource audioSource;
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            Destroy(gameObject, LifeSpan);

        }
    }
}
