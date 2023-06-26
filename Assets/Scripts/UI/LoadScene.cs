using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadSceneFun(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
