using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{
    // STEP 3. UIManager 업그레이드
    // 싱글톤으로 만들기
    // UIMainMenu, UIStatus, UIInventory 프로퍼티로 만들기
    // STEP 2. UIManager 스크립트에 [SerializedField]를 활용하여 3개의 UI를 연결
    [SerializeField] private UIMainMenu uiMainMenu { get; set; }
    [SerializeField] private UIStatus uiStatus { get; set; }
    [SerializeField] private UIInventory uiInventory { get; set; }

    // 프로퍼티로 접근 가능하게 설정
    public UIMainMenu MainMenu => uiMainMenu;
    public UIStatus Status => uiStatus;
    public UIInventory Inventory => uiInventory;

    private void Start()
    {
        uiMainMenu = FindAnyObjectByType<UIMainMenu>(); 
        uiStatus = uiMainMenu.GetComponentInChildren<UIStatus>(true);
        uiInventory = uiMainMenu.GetComponentInChildren<UIInventory>(true);
    }

    public void ShowMainMenu()
    {
        uiStatus.gameObject.SetActive(false);
        uiInventory.gameObject.SetActive(false);
    }

    public void ShowStatus()
    {
        uiStatus.gameObject.SetActive(true);
        uiInventory.gameObject.SetActive(false);
    }

    public void ShowInventory()
    {
        uiStatus.gameObject.SetActive(false);
        uiInventory.gameObject.SetActive(true);
    }
}
