using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;


public class ReadData : MonoBehaviour
{
    
    private const float Checktime = 2.0f;
    float timeToCheck = Checktime;
    SensorData info = new SensorData();
    public TextMeshPro SmartCartText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToCheck -= Time.deltaTime;
        if (timeToCheck <= 0)
        {
            getInfo();
            timeToCheck = Checktime;
        }

        if (info.Id >= 1)
        {
            SmartCartText.text = "Temperature \t: " + info.Temperature + "\nPressure \t\t: " + info.Altitude + "\nHumidity \t\t: " + info.Humidity + "\nAccelerometer \t: " + info.Accelerometer;
            SmartCartText.alignment = TextAlignmentOptions.Justified;
            SmartCartText.fontSize = 4;
        }
    }

    public async void getInfo()
    {
        info = await getData();
    }

    private async Task<SensorData> getData()
    {
        string url = "https://iotardemo.azurewebsites.net/api/Function1?code=FkH06QBazHBJLy1cBil2HRuQAoQQHrGS/VNWKYUgOe9TaxZ60GK5Ig==";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse)(await request.GetResponseAsync());
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        SensorData data = JsonUtility.FromJson<SensorData>(jsonResponse);
        return data;
    }


    //private GUIStyle guiStyle = new GUIStyle();
    //void OnGUI()
    //{
    //    guiStyle.fontSize = 40;
    //    guiStyle.normal.textColor = Color.white;
    //    GUI.Box(new Rect(10, 10, Screen.width, 200), "Smart Cart Detected. Reading sensor data...");
    //    if (info.Id >= 1)
    //    {
    //        GUI.Label(new Rect(20, 40, Screen.width, 20), "Temperature: \t" + this.info.Temperature.ToString(), guiStyle);
    //        GUI.Label(new Rect(20, 80, Screen.width, 20), "Altitude: \t\t" + this.info.Altitude.ToString(), guiStyle);
    //        GUI.Label(new Rect(20, 120, Screen.width, 20), "Humidity: \t" + this.info.Humidity.ToString(), guiStyle);
    //        GUI.Label(new Rect(20, 160, Screen.width, 20), "Accelerometer: \t" + this.info.Accelerometer.ToString(), guiStyle);
    //    }
    //    else
    //    {
    //        GUI.Label(new Rect(20, 40, Screen.width, 20), "Reading Data, Please wait.", guiStyle);
    //    }
    //}
}

public class SensorData
{
    public int Id;
    public string Temperature;
    public string Humidity;
    public string Altitude;
    public string Accelerometer;
}
