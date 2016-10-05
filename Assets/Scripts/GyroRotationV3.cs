using UnityEngine;
using System.Collections;

public class GyroRotationV3 : MonoBehaviour {
    int Calibrated = 0;
    float AY;
    float AZ;
    Vector3 A;
    private GUIStyle Style = new GUIStyle();
    void Start()
    {
        Input.gyro.enabled = true;
        Screen.sleepTimeout = (int)SleepTimeout.NeverSleep;
    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 60, 100, 100), AY.ToString(), Style);
        GUI.Label(new Rect(310, 60, 100, 100), AZ.ToString(), Style);

        Style.fontSize = 50;
    }

    void Update()
    {
        A = Input.acceleration.normalized;
        AY = Mathf.Round(A.y * 100f)/100f;
        AZ = Mathf.Round(A.x * 100f) / 100f;
        if (Calibrated == 1)
        {
            this.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, Input.gyro.rotationRateUnbiased.z);
        }

        if (Calibrated == 0)
        {
            if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft)
            {
                if (AY < -0.97)
                {
                    if (AY > -1)
                    {
                        if (AZ < -0.02)
                        {
                            Calibrated = 1;

                        }
                    }
                }
            }
            else if (Input.deviceOrientation == DeviceOrientation.Portrait)
            {
                Calibrated = 0;
            }
        }
    }
}

