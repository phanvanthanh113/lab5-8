using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayGame()  // Phương thức public
    {
        SceneManager.LoadScene("Level1"); // Đổi tên Scene nếu cần
    }

    public void OpenLevelSelect()  // Phương thức public
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
