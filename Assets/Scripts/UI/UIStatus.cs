using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Button btnBack;

    private void Start()
    {
        btnBack.onClick.AddListener(() => UIManager.Instance.ShowMainMenu());
    }

    // STEP 4. UIMainMenu, UIStatus 클래스에 Chracter 정보를 세팅하는 메서드 추가
    // 보간문자열을 활용하여 각 UI에 캐릭터 정보가 표시
    [SerializeField] private TextMeshProUGUI atkText;
    [SerializeField] private TextMeshProUGUI defText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI criticalText;
    public void UpdateUI(Character player)
    {
        if (player == null) return;

        atkText.text = $"{player.Atk}";
        defText.text = $"{player.Def}";
        hpText.text = $"{player.Hp}";
        criticalText.text = $"{player.Gold}";
    }
}
