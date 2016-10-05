using UnityEngine;
using System.Collections;

public class Joystick_movment : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    public EasyJoystick moveJoy;
    public Vector3 joystick;
    public float Speed = 40f;
    void Update()
    {
        joystick = moveJoy.MoveInput();
        transform.localPosition += transform.TransformDirection(Vector3.right) * (joystick.x * Speed * Time.deltaTime);
        transform.localPosition += transform.TransformDirection(Vector3.forward) * (joystick.z * Speed * Time.deltaTime);
    }
}
