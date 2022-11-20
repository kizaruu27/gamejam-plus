using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string targetScene;

    public void ChangeScene()
    {
        Invoke("SetScene", 2);
    }

    void SetScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}
