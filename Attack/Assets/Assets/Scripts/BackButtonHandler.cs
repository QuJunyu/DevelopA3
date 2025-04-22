using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonHandler : MonoBehaviour
{
    // 这个函数将在 Back 按钮被点击时调用
    public void OnBackButtonClicked()
    {
        SceneManager.LoadScene("Scene 0");
    }
}