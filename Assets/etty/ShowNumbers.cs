using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ShowNumbers : MonoBehaviour
{

    [SerializeField] private Image[] numbersSprite;
    [SerializeField] private Image[] transparencySprite;
    [SerializeField] private Image transparency;
    [SerializeField] private int numbersPlace = 0;

 

    [SerializeField] private BPlayerManager bplayerManager;
    [SerializeField] private BGameManager bGameManager;

    [SerializeField] private Text TextName;
    [SerializeField] private Text [] TextScore;

    private string playerName;

    private void Start()
    {
        bGameManager.OnClick += ClickResults;
    }

    private void ClickResults(int PlayerIndex)
    {

        if (bplayerManager.Pressed == true)
        {
            bplayerManager.Pressed = false;

            for (int i = 0; i < transparencySprite.Length; i++)
            {
                transparencySprite[i].sprite = transparency.sprite;
                numbersPlace = 0;
                Debug.Log("Start Again");
            }

        }

        else
        {
            bplayerManager.Pressed = true;

            transparencySprite[numbersPlace].sprite = numbersSprite[numbersPlace].sprite;

            numbersPlace = (numbersPlace + 1) % numbersSprite.Length;
            Debug.Log("number place is" + numbersPlace);

            bplayerManager.players[PlayerIndex].playerScore++;
            Debug.Log($"score{bplayerManager.players[PlayerIndex].name}: " +
               $"{bplayerManager.players[PlayerIndex].playerScore}");

            TextName.text = bplayerManager.players[PlayerIndex].name;
            TextScore[PlayerIndex].text = bplayerManager.players[PlayerIndex].playerScore.ToString();
            TextName.text = $"Well done: {bplayerManager.players[PlayerIndex].name}";

        }

    }




}
