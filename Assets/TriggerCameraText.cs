using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCameraText : MonoBehaviour
{
    public GameObject cameratext;
    public GameObject wallText;
    public GameObject tvText;
    public bool active = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        active = cameratext.activeInHierarchy;
        wallText.SetActive(false);
        tvText.SetActive(false);
        active = !active;
        cameratext.SetActive(active);

    }
}
