using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject statusOpen;
    public GameObject inventoryOpen;
    
    public void BackMainMenu()
    {
        statusOpen.SetActive(false);
        inventoryOpen.SetActive(false);
    }

    public void OpenStatus()
    {
        statusOpen.SetActive(true);
        inventoryOpen.SetActive(false);
    }

    public void OpenInventory()
    {
        inventoryOpen.SetActive(true);
        statusOpen.SetActive(false);
    }
}
