using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text BestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        BestScoreText.text = "Best Score: " + DataManager.Instance.BestScorerName + " : " + DataManager.Instance.BestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void SetPlayerName()
    {
        string inputText = inputField.GetComponent<TMP_InputField>().text;
        DataManager.Instance.PlayerName = inputText;
    }

    //public void SetBestScoreText()
    //{

    //}
}
