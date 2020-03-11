using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationVR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-0.004f, 0.137f, 0.236f);
        transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
        transform.localScale = new Vector3(0.057f, 0.057f, 0.057f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
