﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTVText : MonoBehaviour
{
    public GameObject wallText;
    public GameObject cameraText;
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
        cameraText.SetActive(false);
        wallText.SetActive(false);
        active = tvText.activeInHierarchy;
        active = !active;
        tvText.SetActive(active);
    }
}