using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public void NewGameBtn(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
