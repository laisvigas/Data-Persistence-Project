using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static string PlayerName;
    public static List<ScoreEntry> TopScores = new List<ScoreEntry>();

    [System.Serializable]
    public class ScoreEntry
    {
        public string PlayerName;
        public int Score;

        public ScoreEntry(string playerName, int score)
        {
            PlayerName = playerName;
            Score = score;
        }
    }

    public static void SaveScores()
    {
        for (int i = 0; i < TopScores.Count; i++)
        {
            PlayerPrefs.SetString($"Player_{i}", TopScores[i].PlayerName);
            PlayerPrefs.SetInt($"Score_{i}", TopScores[i].Score);
        }
        PlayerPrefs.SetInt("ScoreCount", TopScores.Count);
        PlayerPrefs.Save();
    }

    public static void LoadScores()
    {
        TopScores.Clear();
        int count = PlayerPrefs.GetInt("ScoreCount", 0);

        for (int i = 0; i < count; i++)
        {
            string playerName = PlayerPrefs.GetString($"Player_{i}", "None");
            int score = PlayerPrefs.GetInt($"Score_{i}", 0);
            TopScores.Add(new ScoreEntry(playerName, score));
        }
    }
}
