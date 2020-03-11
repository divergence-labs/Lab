using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationIdeaWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.625f, 0.445f, -0.543f);
        transform.rotation = new Quaternion(-0.060f, 0.301f, 0.947f, 0.098f);
        transform.localScale = new Vector3(0.070f, 0.070f, 0.070f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
