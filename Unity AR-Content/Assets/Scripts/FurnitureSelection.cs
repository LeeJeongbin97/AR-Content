using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureSelection : MonoBehaviour
{
    public GameObject[] furniturePrefabs;
    public PlaceFurniture placeFurnitureScript;
    public FurnitureMenuController menuController;

    public void SelectFurniture(int index)
    {
        placeFurnitureScript.SelectFurniture(furniturePrefabs[index]);
        menuController.ToggleFurnitureMenu();
    }

    void Start()
    {
        if (menuController == null)
        {
            menuController = FindObjectOfType<FurnitureMenuController>();
        }
    }
}
