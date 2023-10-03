using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0f, speed, 0f);
    }

    void FixedUpdate()
    {
        speed += Time.fixedDeltaTime;
    }
}
