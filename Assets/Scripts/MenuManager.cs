using UnityEngine;
using TMPro; // Make sure you include the TextMeshPro namespace
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField NameInputField;
    

    public void StartGame()
    {
        if (!string.IsNullOrEmpty(NameInputField.text))
        {
            GameData.PlayerName = NameInputField.text;
            SceneManager.LoadScene("main"); 
        }
        else
        {
            Debug.LogWarning("Player name is empty!");
        }
    }
}
