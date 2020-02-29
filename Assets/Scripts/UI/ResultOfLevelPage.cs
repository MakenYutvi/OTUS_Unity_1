using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultOfLevelPage : MonoBehaviour
{
    public Button ToMainMenuButton;
    public Text TextBoxStaus;
    public GameObject InBattlePageMunu;
    public Image image;
    public AudioSource audioSourceVictory;
    public AudioSource audioSourceDefeat;
    public AudioSource backgroundSound;

    // Start is called before the first frame update
    void Start()
    {
        TextBoxStaus.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TheEndOfLevel(string status, bool victory)
    {
        InBattlePageMunu.SetActive(false);
        TextBoxStaus.gameObject.SetActive(true);
        TextBoxStaus.text = status;
        ToMainMenuButton.gameObject.SetActive(true);
        image.gameObject.SetActive(true);
        backgroundSound.Stop();
        if (victory)
        {
            audioSourceVictory.Play();
        }
        else
        {
            audioSourceDefeat.Play();
        }
    }
}
