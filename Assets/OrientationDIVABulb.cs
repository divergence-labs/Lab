using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationDIVABulb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.868f, 1.429f, 0.019f);
        transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
        transform.localScale = new Vector3(0.095f, 0.095f, 0.095f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
