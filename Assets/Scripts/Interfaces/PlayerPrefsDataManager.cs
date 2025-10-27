using UnityEngine;
using TMPro;

public class PlayerPrefsDataManager : MonoBehaviour
{
    [SerializeField] private TMP_Text displayText;
    [SerializeField] private TMP_InputField nameInput;
    
    private string playerName = "Player";
    private int score = 0;
    private float playtime = 0f;

    void Start()
    {
        LoadData();
        InvokeRepeating("UpdatePlaytime", 1f, 1f);
    }

    public void SaveData()
    {
        
        if (nameInput != null) playerName = nameInput.text;
        PlayerPrefs.SetString("PlayerName", playerName);
        
        
        PlayerPrefs.SetInt("Score", score);
        
        
        PlayerPrefs.SetFloat("Playtime", playtime);
        
        PlayerPrefs.Save();
        UpdateUI();
        Debug.Log("Data Saved!");
    }

    public void LoadData()
    {
        
        playerName = PlayerPrefs.GetString("PlayerName", "Player");
        
        
        score = PlayerPrefs.GetInt("Score", 0);
        
        
        playtime = PlayerPrefs.GetFloat("Playtime", 0f);
        
        UpdateUI();
        Debug.Log("Data Loaded!");
    }

    public void AddScore()
    {
        score += 100;
        SaveData();
    }

    void UpdatePlaytime()
    {
        playtime += 1f;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (displayText != null)
        {
            displayText.text = $"Name: {playerName}\nScore: {score}\nPlaytime: {playtime:F0}s";
        }
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        playerName = "Player";
        score = 0;
        playtime = 0f;
        UpdateUI();
    }

    void OnApplicationQuit()
    {
        SaveData();
    }
}