using UnityEngine;
using UnityEngine.SceneManagement; // Import thư viện quản lý scene

public class SceneChanger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            string currentScene = SceneManager.GetActiveScene().name;

            if (currentScene == "Level1")
            {
                SceneManager.LoadScene("Level2");
            }
            else if (currentScene == "Level4")
            {
                SceneManager.LoadScene("Level5");
            }
            else if (currentScene == "Level5")
            {
                SceneManager.LoadScene("YouWin");
            }
        }
    }
}
