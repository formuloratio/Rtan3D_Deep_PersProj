using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    // STEP 5. UIInventory 스크립트 작성
    // UISlot 타입의 필드 추가 → UISlot 프리팹 추가
    // Trasnform 타입의 slot 부모 추가
    // UISlot 타입의 리스트 추가
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParents;
    [SerializeField] private Button btnBack;
    private List<UISlot> uiSlots = new List<UISlot>();

    private void Start()
    {
        btnBack.onClick.AddListener(() => UIManager.Instance.ShowMainMenu());
    }

    // STEP 5. InitInventoryUI() 메서드 작성 → Start()에서 호출
    // UISlot 리스트, for문, Instantiate 등등 활용
    public void InitInventoryUI()
    {

    }
}
