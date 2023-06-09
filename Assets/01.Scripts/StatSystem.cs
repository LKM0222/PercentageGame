using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//log에 나오는 스탯
public class StatSystem : MonoBehaviour
{
    [SerializeField] Text finalDmgText,dmgText,atkSpdText,defText, incomePercentText, dmgPercentText, expPercentText;
    PlayerStatus thePlayer;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        finalDmgText.text = thePlayer.SetFinalDmg().ToString();
        dmgText.text = thePlayer.Atk.ToString();
        atkSpdText.text = thePlayer.atkSpd.ToString();
        defText.text = thePlayer.defense.ToString();
        incomePercentText.text = thePlayer.incomePercent.ToString();
        dmgPercentText.text = thePlayer.dmgPercent.ToString();
        expPercentText.text = thePlayer.expPercent.ToString();
    }
}
