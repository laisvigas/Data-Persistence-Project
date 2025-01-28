using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField NameInputField;
    public TextMeshProUGUI WarningText;

    public void StartGame()
    {
        string playerName = NameInputField.text.Trim();

        if (string.IsNullOrEmpty(playerName))
        {
            // Warn the user if no name is entered
            Debug.LogWarning("Player name is empty!");
            if (WarningText != null)
            {
                WarningText.text = "Name cannot be empty!";
            }
        }
        else if (playerName.Length > 3)
        {
            // Warn the user if the name doesn't have exactly 3 characters
            Debug.LogWarning("Player name must be exactly 3 characters!");
            if (WarningText != null)
            {
                WarningText.text = "Name must be 3 letters maximum!";
            }
        }
        else
        {
            // If validation passes, set the player's name and load the game
            GameData.PlayerName = playerName;
            SceneManager.LoadScene("main");
        }
    }

    public void BestPlayers()
    {
        SceneManager.LoadScene("BestPlayers");
    }
}
