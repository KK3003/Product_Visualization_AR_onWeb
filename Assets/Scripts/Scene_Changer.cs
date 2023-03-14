using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Changer : MonoBehaviour
{
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
