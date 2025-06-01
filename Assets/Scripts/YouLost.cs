using UnityEngine;
using UnityEngine.SceneManagement;

public class YouLost : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
