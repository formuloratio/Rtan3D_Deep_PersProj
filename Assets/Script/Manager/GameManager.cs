using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    private AudioManager audioManager;
    public AudioManager AM
    {
        get
        {
            if (audioManager == null)
            { //같은 오브젝트에 있기에 GetComponent로 찾을 수 있음
                audioManager = GetComponent<AudioManager>();
                if (audioManager == null)
                {
                    audioManager = gameObject.AddComponent<AudioManager>();
                }
            }
            return audioManager;
        }
    }

    private UIManager uiManager;
    public UIManager UM
    {
        get
        {
            if (uiManager == null)
            { //같은 오브젝트에 있기에 GetComponent로 찾을 수 있음
                uiManager = GetComponent<UIManager>();
                if (uiManager == null)
                {
                    uiManager = gameObject.AddComponent<UIManager>();
                }
            }
            return uiManager;
        }
    }


}
