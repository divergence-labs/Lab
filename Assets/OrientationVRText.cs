using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationVRText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-0.020f, 0.314f, 0.110f);
        transform.rotation = new Quaternion(0.000f, -0.579f, 0.000f, 1.0f);
        transform.localScale = new Vector3(0.068f, 0.068f, 0.068f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
