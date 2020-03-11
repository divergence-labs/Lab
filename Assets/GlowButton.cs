using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlowButton : MonoBehaviour
{
    public Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        button.GetComponent<Image>().color = Color.Lerp(Color.blue, Color.cyan, Mathf.PingPong(Time.time, 1));
    }

    // Update is called once per frame
    void Update()
    {
        button.GetComponent<Image>().color = Color.Lerp(Color.blue, Color.cyan, Mathf.PingPong(Time.time, 1));
        

    }
}
