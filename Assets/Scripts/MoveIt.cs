using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIt : MonoBehaviour { 

    public Vector3 start = new Vector3(3, 1, 0);
    public Vector3 end =  new Vector3(-3, 1, 0);
    public float speed = 1.0f;
    public bool isMoving = true;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float delta = speed * Time.deltaTime;
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, start, delta);
            
            if(transform.position == start)
            {
                isMoving = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, end, delta);
            if (transform.position == end)
            {
                isMoving = true;
            }
        }
    }
}
