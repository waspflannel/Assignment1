using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIt : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotation = new Vector3(30, 60, 90);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation* Time.deltaTime);
    }
}
