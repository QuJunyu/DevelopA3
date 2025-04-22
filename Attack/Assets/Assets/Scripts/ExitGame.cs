using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // 用于退出游戏的方法
    public void QuitGame()
    {
        #if UNITY_EDITOR
            // 如果在编辑器中运行，停止播放
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // 如果是打包后的游戏，退出游戏
            Application.Quit();
        #endif

        Debug.Log("游戏已退出！");
    }
}