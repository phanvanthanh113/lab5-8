using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] private GameObject winZone;
    [SerializeField] private GameData gameData; // Kéo GameData vào Inspector
    private TimeDisplay timeDisplay; // Thêm biến này

    private int goldCount = 0;
    private readonly int totalGold = 3;
    private bool gameEnded = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        timeDisplay = FindObjectOfType<TimeDisplay>(); // Tìm script TimeDisplay

        if (winZone != null)
        {
            winZone.SetActive(false);
        }
    }

    public void CollectGoldenCircle()
    {
        goldCount++;
        Debug.Log($"🔥 Đã thu thập {goldCount}/{totalGold} vàng!");

        if (goldCount >= totalGold && winZone != null)
        {
            winZone.SetActive(true);
            Debug.Log("🎉 WinZone đã xuất hiện!");
        }
    }

    public bool HasCollectedAllGold()
    {
        return goldCount >= totalGold;
    }

    public void WinGame()
    {
        if (!gameEnded && HasCollectedAllGold())
        {
            gameEnded = true;

            float completionTime = timeDisplay.GetTime(); // Lấy thời gian từ TimeDisplay
            timeDisplay.StopTimer(); // Dừng bộ đếm

            gameData.SaveBestTime(completionTime);

            Debug.Log($"🎉 Chiến thắng! Thời gian hoàn thành: {completionTime} giây");
            SceneManager.LoadScene("Level3");
        }
    }
}
