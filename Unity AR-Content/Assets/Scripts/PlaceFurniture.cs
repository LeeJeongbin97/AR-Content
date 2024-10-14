using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceFurniture : MonoBehaviour
{
    private GameObject selectedFurniture;
    public GameObject arCamera;
    public GameObject placementIndicator;

    public void SelectFurniture(GameObject furniturePrefab)
    {
        selectedFurniture = furniturePrefab;
    }

    void Update()
    {
        if (selectedFurniture != null && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = arCamera.GetComponent<Camera>().ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(selectedFurniture, hit.point, Quaternion.identity);
                selectedFurniture = null;
            }
        }
    }
}