using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOpener : MonoBehaviour
{
    [SerializeField]
    private string scene;

    public void OpenScene()
    {
        SceneManager.LoadScene(scene);
    }
}
