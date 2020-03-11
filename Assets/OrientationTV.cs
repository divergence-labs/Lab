using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationTV : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.158f, 0.654f, 0.606f);
        transform.rotation = new Quaternion(0.135f, 0.053f, 0.436f, 0.888f);
        transform.localScale = new Vector3(0.066f, 0.066f, 0.066f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
