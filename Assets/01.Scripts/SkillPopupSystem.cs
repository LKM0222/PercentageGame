using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPopupSystem : MonoBehaviour
{
    DataBase theDB;
    [SerializeField] GameObject[] skill1List = new GameObject[0];

    private void Awake()
    {
        theDB = FindObjectOfType<DataBase>();
    }

    private void Start()
    {
        for(int i = 0; i< skill1List.Length;i++){
            
            skill1List[i].GetComponent<SkillSlot>().SetSkill(theDB.skillList[i]);
        }
    }
}
