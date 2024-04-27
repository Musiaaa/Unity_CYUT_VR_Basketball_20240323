using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Äx²y³õ");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
