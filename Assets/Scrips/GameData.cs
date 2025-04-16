using UnityEngine;

[CreateAssetMenu(fileName = "NewGameData", menuName = "Game/GameData")]
public class GameData : ScriptableObject
{
    public float bestTime = float.MaxValue;

    public void SaveBestTime(float newTime)
    {
        if (newTime < bestTime)
        {
            bestTime = newTime;
        }
    }
}
