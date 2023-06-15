using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopUIscript : MonoBehaviour
{
    [SerializeField] Text playerLevel, playerCoin,playerExp;
    [SerializeField] Slider playerExpSlider;


    DataBase theDB;

    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<DataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        playerLevel.text = theDB.playerLevel.ToString();
        playerCoin.text = theDB.playerCoin.ToString();
        playerExp.text = theDB.playerExp.ToString() + " / " + theDB.playerMaxExp.ToString();
        playerExpSlider.maxValue = theDB.playerMaxExp;
        playerExpSlider.value = theDB.playerExp;
        
    }
}
