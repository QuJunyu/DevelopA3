using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject); // 避免多个
            return;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}