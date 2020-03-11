using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDroneText : MonoBehaviour
{
    public GameObject DroneText;
    public GameObject VideoWallText;
    public GameObject WhiteboardText;
    public bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        VideoWallText.SetActive(false);
        WhiteboardText.SetActive(false);
        active = DroneText.activeInHierarchy;
        active = !active;
        DroneText.SetActive(active);
    }
}
