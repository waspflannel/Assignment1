using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 size;
    public Vector3 newSize;
    public bool isScale = true;
    float scaleSpeed;
    void Start()
    {
        size = transform.localScale;
        newSize = new Vector3(size.x * 4, size.y * 4, size.z * 4);
    }

    // Update is called once per frame
    void Update()
    {
        scaleSpeed = 1f * Time.deltaTime;

        if (isScale)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, newSize, scaleSpeed);
            if (transform.localScale == newSize)
            {
                isScale = false;
            }
        }
        else
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, size, scaleSpeed);
            if (transform.localScale == size)
            {
                isScale = true;
            }
        }
    }
}
