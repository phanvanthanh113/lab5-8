using UnityEngine;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    private TextMeshProUGUI timeText;
    private float elapsedTime = 0f;
    private bool isRunning = true;

    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();

        if (timeText == null)
        {
            Debug.LogError("⚠️ Không tìm thấy TextMeshPro trên GameObject!");
        }
        else
        {
            timeText.text = "Time: 0.00s"; // ✅ Hiển thị ngay từ đầu
        }
    }

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            timeText.text = $"Time: {elapsedTime:F2}s"; // ✅ Định dạng "Time: X.XXs"
        }
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public float GetTime()
    {
        return elapsedTime;
    }
}
