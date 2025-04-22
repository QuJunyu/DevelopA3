using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadGameScenes()
    {
        SceneManager.LoadScene("SampleScene"); // 修改为新的场景名称
    }
}