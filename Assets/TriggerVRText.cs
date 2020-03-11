using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVRText : MonoBehaviour
{
    public GameObject VRText;
    public GameObject MakerSpacesText;
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
        MakerSpacesText.SetActive(false);
        active = VRText.activeInHierarchy;
        active = !active;
        VRText.SetActive(active);
    }
}
