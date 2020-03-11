using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCSText : MonoBehaviour
{
    public GameObject AIText;
    public GameObject IoTText;
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
        AIText.SetActive(false);
        IoTText.SetActive(false);
        active = CSText.activeInHierarchy;
        active = !active;
        CSText.SetActive(active);
    }
}
