using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script that allows the user to rotate the model by clicking and dragging the character left and right
public class rotate : MonoBehaviour
{
    float rotSpeed = 20;

    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
    }
}
