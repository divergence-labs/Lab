using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerIoTRoomText : MonoBehaviour
{
    public GameObject AIRoomText;
    public GameObject CSText;
    public GameObject IoTRoomText;
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
        CSText.SetActive(false);
        AIRoomText.SetActive(false);
        active = IoTRoomText.activeInHierarchy;
        active = !active;
        IoTRoomText.SetActive(active);
    }
}
