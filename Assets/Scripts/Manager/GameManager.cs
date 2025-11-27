using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    // STEP 4. GameManager 스크립트 작성
    // player 프로퍼티 추가
    public Character Player { get; private set; }

    private void Start()
    {
        SetData();
    }

    // STEP 4. SetData() 메서드를 만들기
    // 생성자를 통해 Player 생성하면서 Player에 데이터를 넣기
    // 각 UI에 작성된 Character 정보를 세팅하는 메서드에 Player 인자로 전달 -> ???
    private void SetData()
    {
        Player = new Character("나의이름은", 1, 10, 5, 100, 1500, "그냥 캐릭터입니다.", 15);

        // UIManager의 인스턴스를 통해 UIMainMenu에 접근하여 UI를 갱신
        if (UIManager.Instance != null && UIManager.Instance.MainMenu != null)
        {
            UIManager.Instance.MainMenu.UpdateUI(Player);
        }
        if (UIManager.Instance != null && UIManager.Instance.MainMenu != null)
        {
            UIManager.Instance.Status.UpdateUI(Player);
        }
    }
}
