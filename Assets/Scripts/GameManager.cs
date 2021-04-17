using UnityEngine;
using UnityEngine.SceneManagement;

//Simple class for reloading scene
public class GameManager : MonoBehaviour
{
    InputMaster input;
    public void Awake()
    {
        input = new InputMaster();
        input.GameManager.ReloadScene.performed += context => ReloadScene();
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
