using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenucontroller : MonoBehaviour
{
    public void GoToLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit button clicked");
    }
}
