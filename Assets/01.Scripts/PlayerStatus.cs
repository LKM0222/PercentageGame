using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//플레이어의 현재 상태 (어떤 장비를 착용중인지, ...)
//착용중인 장비의 코드를 가져오자.
public class PlayerStatus : MonoBehaviour
{
    public Item equip_item_head, equip_item_body, equip_item_pants, equip_item_shoose, equip_item_weapon;

    DataBase theDB;
    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<DataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        equip_item_head = theDB.equipWeponList[0];
        equip_item_body = theDB.equipWeponList[1];
        equip_item_pants = theDB.equipWeponList[2];
        equip_item_shoose = theDB.equipWeponList[3];
        equip_item_weapon = theDB.equipWeponList[4];
        
        
    }

    
}
