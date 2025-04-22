using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpButtonHandler : MonoBehaviour
{
    // 这个函数将在 Help 按钮被点击时调用
    public void OnHelpButtonClicked()
    {
        SceneManager.LoadScene("Scene 2");
    }
}