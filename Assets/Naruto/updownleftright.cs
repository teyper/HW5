using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updownmove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float Speed = 2f;
    [SerializeField] float Ymin = -7f; // lower boundary 
    [SerializeField] float Ymax = 7f; //upper boundary
    [SerializeField] float Xmin = -7.7f;
    [SerializeField] float Xmax = -3.2f;
    [SerializeField] GameObject rasengyspritePrefab; //
    //where the rasengan if coming from off naruto
    [SerializeField] float rasengy_x_offset = 0f;
    [SerializeField] float rasengy_y_offset = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        float y;
      

        y = Input.GetAxis("Vertical");
       

        transform.Translate(0f, y * Speed * Time.deltaTime, 0f);
        
        // boundary above Ymax
        if (transform.position.y > Ymax)
        {
            transform.position = new Vector3(transform.position.x, Ymax, transform.position.z);
        }
        //boundary below Ymin
        if (transform.position.y < Ymin)
        {
            transform.position = new Vector3(transform.position.x, Ymin, transform.position.z);
        }
        // boundary outside Xmax
        if (transform.position.x > Xmax)
        {
            transform.position = new Vector3(Xmax, transform.position.y, transform.position.z);
        }
        //boundary outside Xmin
        if (transform.position.x < Xmin)
        {
            transform.position = new Vector3(Xmin, transform.position.y, transform.position.z);
        }

        if (Input.GetButtonDown("Fire1"))  // instatiate rasengan
        {
            GameObject obj;
            obj = Instantiate(rasengyspritePrefab);
            //move ransengan to naruto hand
            obj.transform.position = transform.position;
            obj.transform.Translate(rasengy_x_offset, rasengy_y_offset, 0f);

        }
    }
}
       