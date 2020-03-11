using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationCameraText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-0.219f, -0.033f, -0.039f);
        transform.rotation = new Quaternion(-0.045f, -0.634f, 0.037f, -0.771f);
        transform.localScale = new Vector3(0.039f, 0.039f, 0.039f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
