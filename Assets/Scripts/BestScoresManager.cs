using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoresManager : MonoBehaviour
{
    public Text BestScoresText;

    private void Start()
    {
        GameData.LoadScores();

        if (BestScoresText != null)
        {
            BestScoresText.text = "Top 5 Scores:\n";
            int rank = 1;
            foreach (var scoreEntry in GameData.TopScores)
            {
                BestScoresText.text += $"{rank}. {scoreEntry.PlayerName}: {scoreEntry.Score} points\n";
                rank++;
            }
        }
    }

    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
    }
}
