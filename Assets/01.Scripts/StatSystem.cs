using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatSystem : MonoBehaviour
{
    [SerializeField] Text dmgText,atkSpdText;
    DataBase theDB;
    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<DataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        dmgText.text = theDB.dmg.ToString();
        atkSpdText.text = theDB.atkSpd.ToString();
    }
}
