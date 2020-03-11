using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDIVAText : MonoBehaviour
{

    public GameObject meetDIVA;
    public GameObject bulbDIVA;
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
        bulbDIVA.SetActive(false);
        active = meetDIVA.activeInHierarchy;
        active = !active;
        meetDIVA.SetActive(active);
    }
}
