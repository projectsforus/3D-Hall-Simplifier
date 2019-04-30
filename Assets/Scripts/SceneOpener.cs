using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOpener : MonoBehaviour {

	public void SceneChangerMethod(string SceneName) {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
    }
}
