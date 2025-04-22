using UnityEngine;

public class MusicAutoStopper : MonoBehaviour
{
    void Start()
    {
        GameObject musicPlayer = GameObject.FindGameObjectWithTag("Music");
        if (musicPlayer != null)
        {
            Destroy(musicPlayer); // 停止播放并移除对象
        }
    }
}