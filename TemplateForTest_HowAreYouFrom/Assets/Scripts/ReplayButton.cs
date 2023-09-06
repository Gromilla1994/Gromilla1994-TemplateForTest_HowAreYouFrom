using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour
{
    public void Replay()
    {
        Debug.Log("0");
        SceneManager.LoadScene(0);
    }
}
