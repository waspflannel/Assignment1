using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        transform.position = new Vector3(5.5f, 8.5f, -12f);
        transform.rotation = Quaternion.Euler(30.0f, -25.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            newPosition.z += 0.5f*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPosition.z -= 0.5f * Time.deltaTime;
        }
        transform.position = newPosition;
    }
}
