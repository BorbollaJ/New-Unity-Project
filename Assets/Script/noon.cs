using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noon : MonoBehaviour
{
    public float rotationSpeed = 1;
    //public float rotationLength = 10;
    public float sAngle;
    public float eAngle;

    //public Vector3 startAngle;
    //public Vector3 endAngle;
    //Vector3 curVe1 = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        // Take A - SmoothDanping between two vectors
        //this.transform.eulerAngles = startAngle;



        Vector3 angle = this.transform.eulerAngles;
        angle.y = sAngle;
        this.transform.eulerAngles = angle;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.eulerAngles = Vector3.SmoothDamp(this.transform.eulerAngles, endAngle, ref curVe1, rotationSpeed);


        Vector3 tempAngle = this.transform.eulerAngles;
        tempAngle.y = tempAngle.y + rotationSpeed * Time.deltaTime;

        this.transform.eulerAngles = tempAngle;
    }
}
