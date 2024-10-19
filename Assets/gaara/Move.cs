using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    bool goingUP = true;
    [SerializeField] float Speed = 2.8f;
    [SerializeField] float YLimit = 3.5f;
    [SerializeField] GameObject SandPrefab;
    [SerializeField] GameObject KittyPrefab;
    [SerializeField] float SandMinInstantiationTime = 0.25f;
    [SerializeField] float SandMaxInstantiationTime = 3f;
    [SerializeField] float KittyMinInstantiationTime = 0.45f;
    [SerializeField] float KittyMaxInstantiationTime = 2f;

    //podition offsets
    [SerializeField] float kitty_x_offset = 0f;
    [SerializeField] float kitty_y_offset = 0f;
    

    void Start()
    {
        Invoke("InstantiateKitty", 1f);
        Invoke("InstantiateSand", 1f);
    }
    // Update is called once per frame
    void Update()
    {
        // Moving up or down based on goingUP boolean
        if (goingUP)
        {
            transform.Translate(0f, Speed * Time.deltaTime, 0f);  // Move up
            if (transform.position.y > YLimit)
            {
                goingUP = false;  // Switch direction at upper limit
            }
        }
        else
        {
            transform.Translate(0f, -Speed * Time.deltaTime, 0f);  // Move down
            if (transform.position.y < -YLimit)
            {
                goingUP = true;  // Switch direction at lower limit
            }
        }

    }

   public void InstantiateKitty() //generate kitty prefab 
    {

        GameObject kitty;
        kitty = Instantiate(KittyPrefab);
        float SpaceBetweenKittyAndSand = Random.Range(kitty_x_offset, kitty_y_offset);
        //kitty.transform.Translate(kitty_x_offset, kitty_y_offset, 0f);
        float TimeToWaitBeforeNextKitty = Random.Range(KittyMinInstantiationTime, KittyMaxInstantiationTime);
        Invoke("InstantiateKitty", 1f);

    }

    public void InstantiateSand() // generate sand prefab 
    {
        GameObject sand;
        sand = Instantiate(SandPrefab);
        sand.transform.position = transform.position;
        float TimeToWaitBeforeNextSand = Random.Range(SandMaxInstantiationTime, SandMinInstantiationTime);
        Invoke("InstantiateSand", 1f);
    }
}
