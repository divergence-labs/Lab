using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDIVABulbText : MonoBehaviour
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
        meetDIVA.SetActive(false);
        active = bulbDIVA.activeInHierarchy;
        active = !active;
        bulbDIVA.SetActive(active);
    }
}
