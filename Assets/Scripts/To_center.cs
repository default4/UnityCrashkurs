using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class To_center : MonoBehaviour
{
    public Transform objectToRotate;
    public Transform rotationCenter;
    public float rotationSpeed = 30f;
    private bool isPaused = false;
	public Button button_to_center;

    void Start()
    {
        button_to_center.onClick.AddListener(RotateToggle);
    }

    void RotateToggle()
    {
        isPaused = !isPaused;
    }

    void Update()
    {
        if (!isPaused)
        {
            objectToRotate.RotateAround(rotationCenter.position, Vector3.up, rotationSpeed * Time.deltaTime);
			
        }
    }
}