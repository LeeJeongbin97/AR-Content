using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureInteraction : MonoBehaviour
{
    private float initialPinchDistance;
    private Vector3 initialScale;
    private bool isRotating = false;

    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            isRotating = true;
            float rotationSpeed = 0.1f;
            float rotation = Input.GetTouch(0).deltaPosition.x * rotationSpeed;
            transform.Rotate(0, -rotation, 0);
        }
        else if (Input.touchCount == 2)
        {
            isRotating = false;
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            if (touch0.phase == TouchPhase.Moved || touch1.phase == TouchPhase.Moved)
            {
                float currentDistance = Vector2.Distance(touch0.position, touch1.position);

                if (initialPinchDistance == 0)
                {
                    initialPinchDistance = currentDistance;
                    initialScale = transform.localScale;
                }
                else
                {
                    float scaleMultiplier = currentDistance / initialPinchDistance;
                    transform.localScale = initialScale * scaleMultiplier;
                }
            }
        }
        else
        {
            initialPinchDistance = 0;
        }
    }
}