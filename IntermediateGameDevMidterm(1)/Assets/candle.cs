using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candle : MonoBehaviour
{
    // Start is called before the first frame update
    private float myRayDist = 1.7f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("fuck");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ffffff");
        //declareRay
        Ray myRay = new Ray(transform.position, Vector3.down);

        Debug.DrawRay(myRay.origin, myRay.direction * myRayDist, Color.cyan);

        if (Physics.Raycast(myRay, myRayDist))
        {
            Debug.Log("groundhit");
        }
        else
        {
            Debug.Log("Off Ground");
        }
    }
}
