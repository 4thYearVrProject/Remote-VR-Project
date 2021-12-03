using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

used for non-VR user to look around the 360 video

*/
public class LookAround : MonoBehaviour
{
    public float look_speed = 5;

    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButton(0)) {
          transform.RotateAround(transform.position, -Vector3.up, look_speed * Input.GetAxis("Mouse X"));
          transform.RotateAround(transform.position, transform.right, look_speed * Input.GetAxis("Mouse Y"));
        }
    }
}
