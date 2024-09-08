using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 45f;
    [SerializeField] private Transform rotateAround;

    private bool autoRotate = false;

    void Update()
    {
        RotatePlanet();
    }

    public void RotatePlanet()
    {
        if (Input.GetKey(KeyCode.R)) { 
            ToggleAutoRotateR();
        }

        if (Input.GetKey(KeyCode.T))
        {
            ToggleAutoRotateL();
        }

        if (!autoRotate)
        {
            this.transform.RotateAround(rotateAround.position, Vector3.forward, -rotationSpeed * Time.deltaTime);
        }

        if (autoRotate)
        {
            this.transform.RotateAround(rotateAround.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        }
        
    }

    public void ToggleAutoRotateR()
    {
        this.autoRotate = !this.autoRotate;
    }
    public void ToggleAutoRotateL()
    {
        this.autoRotate = false;
    }
}
