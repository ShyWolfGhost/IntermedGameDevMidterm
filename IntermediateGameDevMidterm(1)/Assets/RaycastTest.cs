using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(myRay.origin, myRay.direction*10f, Color.green);       
    }
}
