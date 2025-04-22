using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump_Scenes : MonoBehaviour
{
    public void tz(int i)//跳转场景
    {
        SceneManager.LoadScene(i);
    }

    public void quitgame()//退出游戏
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void Res()//重新游戏
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
