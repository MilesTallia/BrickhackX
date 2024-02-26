using UnityEngine;
using UnityEngine.SceneManagement;

public class TowerBack : MonoBehaviour {

    public void NextScene() {
        SceneManager.LoadScene("Map");
    }
}
