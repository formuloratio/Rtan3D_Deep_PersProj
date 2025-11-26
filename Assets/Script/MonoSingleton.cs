using Unity.VisualScripting;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : Component
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                SetupInstance();
            }
            return instance;
        }
    }

    private static void SetupInstance()
    {
        instance = FindAnyObjectByType<T>();
        if (instance != null) //씬에 해당 오브젝트가 없는 경우
        {
            instance = new GameObject(typeof(T).Name).AddComponent<T>();
            DontDestroyOnLoad(instance.gameObject);
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(instance.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
