using UnityEngine;
using System.Collections;

public class Debug : MonoBehaviour {
    Vector3 prevMag;
    string X = "-";
    string Y = "-";
    string Z = "-";
    string A = "-";
    private GUIStyle Style = new GUIStyle();

    void Start()
    {
        Input.compass.enabled = true;
    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), X, Style);
        GUI.Label(new Rect(310, 10, 100, 100), Y, Style);
        GUI.Label(new Rect(610, 10, 100, 100), Z, Style);
        GUI.Label(new Rect(910, 10, 100, 100), A, Style);
        Style.fontSize = 50;
    }

    void Update()
    {
        X = Input.gyro.rotationRateUnbiased.x.ToString();
        Y = Input.gyro.rotationRateUnbiased.y.ToString();
        Z = Input.gyro.rotationRateUnbiased.z.ToString();
        A = Input.acceleration.normalized.ToString();


        
       
    }
 
}

