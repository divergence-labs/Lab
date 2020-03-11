using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationDrones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1.145f, 0.300f, 1.239f);
        transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
        transform.localScale = new Vector3(0.077f, 0.077f, 0.077f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
