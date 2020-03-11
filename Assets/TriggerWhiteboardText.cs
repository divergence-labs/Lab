using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWhiteboardText : MonoBehaviour
{
    public GameObject WhiteboardText;
    public GameObject VideowallText;
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
        VideowallText.SetActive(false);
        active = WhiteboardText.activeInHierarchy;
        active = !active;
        WhiteboardText.SetActive(active);
    }
}
