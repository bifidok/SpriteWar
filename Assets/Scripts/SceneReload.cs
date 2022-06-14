using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneReload : MonoBehaviour
{
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
