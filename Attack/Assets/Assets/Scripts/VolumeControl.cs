using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider; // 用于控制音量的 Slider
    private AudioSource audioSource; // 用于控制音量的 AudioSource

    void Start()
    {
        // 获取场景中 MusicPlayer 物体上的 AudioSource 组件
        audioSource = GameObject.Find("MusicPlayer").GetComponent<AudioSource>();

        // 确保音源存在并且 Slider 可用
        if (audioSource != null && volumeSlider != null)
        {
            // 初始化时将 Slider 的值设置为当前音量
            volumeSlider.value = audioSource.volume;

            // 为 Slider 设置监听器，当 Slider 的值发生改变时调用 SetVolume 方法
            volumeSlider.onValueChanged.AddListener(SetVolume);
        }
        else
        {
            Debug.LogError("AudioSource or Slider not assigned properly!");
        }
    }

    // 设置音量的方法
    void SetVolume(float volume)
    {
        if (audioSource != null)
        {
            // 设置 AudioSource 的音量为 Slider 的值
            audioSource.volume = volume;
        }
    }
}