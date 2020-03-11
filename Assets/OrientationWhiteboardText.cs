using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationWhiteboardText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-1.072f, 0.651f, 0.888f);
        transform.rotation = new Quaternion(0.005f, -0.042f, -0.012f, 0.999f);
        transform.localScale = new Vector3(0.030f, 0.030f, 0.030f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
