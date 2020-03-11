using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAIRoomText : MonoBehaviour
{
    public GameObject AIRoomText;
    public GameObject IoTRoomText;
    public GameObject CSText;
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
        IoTRoomText.SetActive(false);
        active = AIRoomText.activeInHierarchy;
        active = !active;
        AIRoomText.SetActive(active);
    }
}
