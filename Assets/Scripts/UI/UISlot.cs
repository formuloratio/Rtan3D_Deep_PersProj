using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    // STEP 5. UISlot 스크립트 추가하고, UI 구성요소에 연결될 필드 추가(SerializedField)
    [SerializeField] private GameObject equippedMark;
    [SerializeField] private Button btnEquip;

    private Item _item;

    // STEP 5. SetItem(), RefreshUI() 메서드 추가
    public void SetItem(Item item)
    {
        _item = item;
        RefreshUI();
    }

    public void RefreshUI()
    {

    }
}
