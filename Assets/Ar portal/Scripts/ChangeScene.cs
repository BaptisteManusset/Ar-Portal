
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public SceneReference scene;
    public void SetScene()
    {
        SceneManager.LoadScene(scene);
    }
}
