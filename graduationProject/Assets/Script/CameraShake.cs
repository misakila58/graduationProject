using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraShake : MonoBehaviour
{
    // Transform of the camera to shake. Grabs the gameObject's transform
    // if null.
    public Transform camTransform;

    // How long the object should shake for.
    public float shakeDuration = 0f;

    // Amplitude of the shake. A larger value shakes the camera harder.
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;
    bool left;
    int count;
  
    Vector3 originalPos;

    void Awake()
    {

        left = true;
        count = 0;
     
        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
    }


    //IEnumerator ShakeCamera() //960 기본 1100, 820
  

    void ShakeCamera()
    {

        if (left == true)
        {
            camTransform.localPosition += new Vector3(0.7f * count, 0, 0);
            if (camTransform.position.x >= 1000)
            {
                left = false;
            }
        }
        else if (left == false)
        {
            camTransform.localPosition -= new Vector3(0.7f * count , 0, 0);
            if (camTransform.position.x <=900)
            {
                left = true;
            }
        }

    }


    void OnEnable()
    {
        originalPos = camTransform.localPosition;
    }

    void Update()
    {

        ShakeCamera();
        //if(left)
        //{
        //    for(count = 0; count<countTemp+10; count++)
        //    {
        //        camTransform.localPosition += (new Vector3(0.01f, 0, 0));
        //        left = false;
        //    }

        //    if (countTemp <= 190)
        //        countTemp += 10;
        //    else
        //        countTemp %= 10;

        //}
        //else
        //{
        //    for (count = 0; count < countTemp + 10; count++)
        //    {
        //        camTransform.localPosition += (new Vector3(-0.01f, 0, 0));
        //        left = true;
        //    }
        //    if (countTemp <= 200)
        //        countTemp += 10;
        //    else
        //        countTemp %= 10;
        //}



        //if (shakeDuration > 0)
        //{
        //    camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

        //    shakeDuration -= Time.deltaTime * decreaseFactor;
        //}
        //else
        //{
        //    shakeDuration = 0f;
        //    camTransform.localPosition = originalPos;
        //}
    }
}

