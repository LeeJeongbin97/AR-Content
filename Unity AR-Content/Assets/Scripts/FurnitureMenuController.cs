using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureMenuController : MonoBehaviour
{
    public GameObject furnitureMenuPanel;
    private bool isMenuOpen = false;

    public void ToggleFurnitureMenu()
    {
        isMenuOpen = !isMenuOpen;
        furnitureMenuPanel.SetActive(isMenuOpen);
    }

    public void HideFurnitureMenu()
    {
        isMenuOpen = false;
        furnitureMenuPanel.SetActive(false);
    }
}