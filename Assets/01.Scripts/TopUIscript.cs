using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopUIscript : MonoBehaviour
{
    [SerializeField] Text playerLevel, playerCoin,playerExp;
    [SerializeField] Slider playerExpSlider;

    PlayerStatus thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        playerLevel.text = thePlayer.playerLevel.ToString();
        playerCoin.text = thePlayer.playerCoin.ToString();
        playerExp.text = thePlayer.playerExp.ToString() + " / " + thePlayer.playerMaxExp.ToString();
        playerExpSlider.maxValue = thePlayer.playerMaxExp;
        playerExpSlider.value = thePlayer.playerExp;
        
    }
}
