using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVideoWallText : MonoBehaviour
{
    public GameObject VideoWallText;
    public GameObject WhiteboardText;
    public GameObject DroneText;
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
        DroneText.SetActive(false);
        WhiteboardText.SetActive(false);
        active = VideoWallText.activeInHierarchy;
        active = !active;
        VideoWallText.SetActive(active);

    }
}
