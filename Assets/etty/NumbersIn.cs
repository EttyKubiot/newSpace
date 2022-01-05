using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumbersIn : MonoBehaviour
{
    [SerializeField] private GameObject[] numbers;

    [SerializeField] private int numbersPlace = 0;



    [SerializeField] private BPlayerManager bplayerManager;
    [SerializeField] private BGameManager bGameManager;

    [SerializeField] private Text TextName;
    [SerializeField] private Text[] TextScore;

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

            GameObject[] clones = GameObject.FindGameObjectsWithTag("numberClone");
            foreach (GameObject numberClone in clones)
                GameObject.Destroy(numberClone);
            //Destroy(GameObject.FindGameObjectWithTag("numberClone"));
            numbersPlace = 0;
                Debug.Log("Start Again");
           

        }

        else
        {
            bplayerManager.Pressed = true;
            Instantiate(numbers[numbersPlace]);
           

            numbersPlace = (numbersPlace + 1) % numbers.Length;
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
