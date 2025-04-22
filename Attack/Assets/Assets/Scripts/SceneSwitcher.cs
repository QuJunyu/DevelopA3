using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // 检测按下“M”键
        if (Input.GetKeyDown(KeyCode.M))
        {
            // 加载“Scene 0”
            SceneManager.LoadScene("Scene 0");
        }
    }
}