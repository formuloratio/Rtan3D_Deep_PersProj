using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    // STEP 3. UIMainMenu 메서드 내용 작성
    // UIManager를 통해 각 UI에 접근해서 켜기
    [SerializeField] private Button btnStatus;
    [SerializeField] private Button btnInventory;

    // STEP 3. 버튼 추가하기
    // 각 UI의 Start() 메서드에 AddListener를 활용해서 추가
    private void Start()
    {
        btnStatus.onClick.AddListener(OpenStatus);
        btnInventory.onClick.AddListener(OpenInventory);
    }

    // STEP 3. UIMainMenu의 스크립트를 작성합니다.
    // OpenMainMenu, OpenStatus, OpenInventory 메서드 추가.
    private void OpenMainMenu()
    {
        UIManager.Instance.ShowMainMenu();
    }

    private void OpenStatus()
    {
        UIManager.Instance.ShowStatus();
    }

    private void OpenInventory()
    {
        UIManager.Instance.ShowInventory();
    }

    // STEP 4. UIMainMenu, UIStatus 클래스에 Chracter 정보를 세팅하는 메서드 추가
    // 보간문자열을 활용하여 각 UI에 캐릭터 정보가 표시
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private TextMeshProUGUI goldText;
    public void UpdateUI(Character player)
    {
        if (player == null) return;

        nameText.text = $"{player.Name}";
        levelText.text = $"{player.Level}";
        descriptionText.text = $"{player.Description}";
        goldText.text = $"{player.Gold}";
    }
}
