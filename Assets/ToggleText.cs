using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleText : MonoBehaviour
{
    public GameObject tvText;
    public GameObject cameraText;
    public GameObject wallText;
    public Button tvButton;
    public Button cameraButton;
    public Button wallButton;
    public bool active = false;
    public string activeObject = "";
    // Start is called before the first frame update
    void Start()
    {
        tvButton.onClick.AddListener(DisplayTvText);
        cameraButton.onClick.AddListener(DisplayCameraText);
        wallButton.onClick.AddListener(DisplayWallText);
    }

    void DisplayTvText()
    {
        if (activeObject == "")
        {
            tvText.SetActive(true);
            activeObject = "tv";
        }
        else if (activeObject == "camera")
        {
            cameraText.SetActive(false);
            tvText.SetActive(true);
            activeObject = "tv";
        }
        else if (activeObject == "wall")
        {
            wallText.SetActive(false);
            tvText.SetActive(true);
            activeObject = "tv";
        }
        else if (activeObject == "tv")
        {
            tvText.SetActive(false);
            activeObject = "";
        }

    }

    void DisplayCameraText()
    {
        if (activeObject == "")
        {
            cameraText.SetActive(true);
            activeObject = "camera";
        }
        else if (activeObject == "camera")
        {
            cameraText.SetActive(false);
            activeObject = "";
        }
        else if (activeObject == "wall")
        {
            wallText.SetActive(false);
            cameraText.SetActive(true);
            activeObject = "camera";
        }
        else if (activeObject == "tv")
        {
            tvText.SetActive(false);
            cameraText.SetActive(true);
            activeObject = "camera";
        }

    }

    void DisplayWallText()
    {
        if (activeObject == "")
        {
            wallText.SetActive(true);
            activeObject = "wall";
        }
        else if (activeObject == "camera")
        {
            cameraText.SetActive(false);
            wallText.SetActive(true);
            activeObject = "wall";
        }
        else if (activeObject == "wall")
        {
            wallText.SetActive(false);
            activeObject = "";
        }
        else if (activeObject == "tv")
        {
            tvText.SetActive(false);
            wallText.SetActive(true);
            activeObject = "wall";
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}


