using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationCSRoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.324f, 0.376f, -0.379f);
        transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
        transform.localScale = new Vector3(0.049f, 0.049f, 0.049f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
