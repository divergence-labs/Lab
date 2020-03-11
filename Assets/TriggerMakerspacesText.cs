using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMakerspacesText : MonoBehaviour
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
        VRText.SetActive(false);
        active = MakerSpacesText.activeInHierarchy;
        active = !active;
        MakerSpacesText.SetActive(active);
    }
}
