using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//log에 나오는 스탯
public class StatSystem : MonoBehaviour
{
    [SerializeField] Text finalDmgText,dmgText,atkSpdText,defText, incomePercentText, dmgPercentText, expPercentText;
    PlayerStatus thePlayer;
    DataBase theDB;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerStatus>();
        theDB = FindObjectOfType<DataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        finalDmgText.text = thePlayer.SetFinalDmg().ToString();
        dmgText.text = theDB.Atk.ToString();
        atkSpdText.text = theDB.atkSpd.ToString();
        defText.text = theDB.defense.ToString();
        incomePercentText.text = theDB.incomePercent.ToString();
        dmgPercentText.text = theDB.dmgPercent.ToString();
        expPercentText.text = theDB.expPercent.ToString();
    }
}
