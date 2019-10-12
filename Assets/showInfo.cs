using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showInfo : MonoBehaviour
{
    public Text PanelNameText;
    public Text PanelLivesText;
    public Text PanelSpeedText;
    public Text PanelScoreText;
    public Text PanelHighScoreText;
    public Text PanelRoundsPlayedText;
    // Start is called before the first frame update
   public void Awake()
    {
        PanelNameText.text = keepInfo.PlayerName.ToString();
        PanelLivesText.text = keepInfo.PlayerLives.ToString();
        PanelSpeedText.text = keepInfo.PlayerSpeed.ToString();
        PanelHighScoreText.text = "High: " + keepInfo.HighScore.ToString();
        PanelRoundsPlayedText.text = "Rounds: " + keepData.RoundsPlayed.ToString();
    }
        
    
    // Update is called once per frame
    public void Update()
    {
        PanelScoreText.text = Score.PinCount.ToString();
    }
}
