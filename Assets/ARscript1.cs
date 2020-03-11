using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wikitude;

public class ARscript1 : MonoBehaviour
{
    string label_name = "";
    public ObjectTarget obj;
    public GameObject LobbyProjection;
    public GameObject IdeationRoomProjection;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void OnObjectRecognized(ObjectTarget recognizedTarget)
    {
        label_name = "Hi";
        

        if (recognizedTarget.Name == "Lobby")
        {
            IdeationRoomProjection.SetActive(false);
            LobbyProjection.SetActive(true);
            LobbyProjection.transform.parent = recognizedTarget.Drawable.transform;
        }
        else if (recognizedTarget.Name == "IdeationRoom")
        {
            LobbyProjection.SetActive(false);
            IdeationRoomProjection.SetActive(true);
            IdeationRoomProjection.transform.parent = recognizedTarget.Drawable.transform;
        }

    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 300, 100), "Occluder Transform");
        GUI.Label(new Rect(20, 40, 300, 20), "Position: " + label_name);
        //GUI.Label(new Rect(20, 60, 300, 20), "Rotation: " + this.transform.rotation.ToString("F3"));
        //GUI.Label(new Rect(20, 80, 300, 20), "Scale: " + this.transform.localScale.ToString("F3"));
    }

}
