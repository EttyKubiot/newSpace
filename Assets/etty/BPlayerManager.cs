using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BPlayerManager : MonoBehaviour
{
    [SerializeField] private BGameManager bGameManager;
    [SerializeField] private MenuUi menuUi;

    public List<BPlayerData> players = new List<BPlayerData>();
    private List<KeyCode> myKeys = new List<KeyCode>();
    //private List<string> playerName = new List<string>();
    //private List<InputField> inputName = new List<InputField>();

    public bool Pressed = false;
    //[SerializeField] private InputField inputField;
    //[SerializeField] private InputField inputField1;

    public string myName;
    public string myName1;

    private void Start()
    {
      
    }


    void Awake()
    {
        myName = PlayerPrefs.GetString("name2");
        myName1 = PlayerPrefs.GetString("name3");
        //bGameManager.OnValueChanged += CheckIfOnValueChanged;
        players.Add(new BPlayerData("", KeyCode.Alpha0));
        players.Add(new BPlayerData("", KeyCode.Alpha1));
        players[0].playerScore = 0;

        for (int i = 0; i < players.Count; i++)
        {
            myKeys.Add(players[i].keyCode);
            players[0].name = myName;
            players[1].name = myName1;
            //playerName.Add(players[i].name = inputName[i].text);
        }
    }


    public void CheckIfOnValueChanged()
    {

        //myName = inputField.text;
        //myName1 = inputField1.text;
        //for (int i = 0; i < players.Count; i++)
        //{
        //    players[0].name = myName;
        //    players[1].name = myName1;
        //    //playerName.Add(players[i].name = inputName[i].text);
        //}
 
    }


    void Update()
    {
        

        for (int i = 0; i < myKeys.Count; i++)
        {
            if (Input.GetKeyDown(myKeys[i]))
            {
                Debug.Log(players[i].name);
                StartCoroutine(ClickOver());
                bGameManager.OnClick?.Invoke(i);
            }
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    bGameManager.OnValueChanged?.Invoke();
        //}
    }

    private IEnumerator ClickOver()
    {
        yield return new WaitForSeconds(0.2f);
        Pressed = false;
    }

}
