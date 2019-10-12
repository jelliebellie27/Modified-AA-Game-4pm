using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepInfo : MonoBehaviour

{
    public static string PlayerName = " ";
    public static int PlayerLives;
    public static int HighScore;
    public static float PlayerSpeed;
    public static int RoundsPlayed = 0;

    public InputField PlayerNameInput;
    public Slider PlayerSpeedSlider;
    public Dropdown PlayerLivesDropdown;

    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    private void Update()
    { }
    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
    }
    public void SetLives()
    {
        PlayerLives = PlayerLivesDropdown.value;

    }
    public void ChangeSpeed()
    {
        PlayerSpeed = PlayerSpeedSlider.value;
    }
}