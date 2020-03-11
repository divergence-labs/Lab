using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            //Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            //transform.Translate(0, 0, touchDeltaPosition.y * 0.001f);
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Rotate(0, -touchDeltaPosition.x * 0.1f, 0);
        }

        else if (Input.touchCount == 2 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            //Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            //transform.Translate(0, 0, touchDeltaPosition.y * 0.001f);
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Rotate( -touchDeltaPosition.y * 0.1f, 0, 0);
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 300, 100), "Occluder Transform");
        GUI.Label(new Rect(20, 40, 300, 20), "Position: " + this.transform.position.ToString("F3"));
        GUI.Label(new Rect(20, 60, 300, 20), "Rotation: " + this.transform.rotation.ToString("F3"));
        GUI.Label(new Rect(20, 80, 300, 20), "Scale: " + this.transform.localScale.ToString("F3"));
    }
}
