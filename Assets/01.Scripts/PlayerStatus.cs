using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//플레이어의 현재 상태 (어떤 장비를 착용중인지, ...)
//착용중인 장비의 코드를 가져오자.
public class PlayerStatus : MonoBehaviour
{
    public int equip_item_head, equip_item_body, equip_item_pants, equip_item_shoose, equip_item_weapon;

    DataBase theDB;
    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<DataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        equip_item_head = 2001;
        equip_item_body = 2002;
        equip_item_pants = 2003;
        equip_item_shoose = 2004;
        equip_item_weapon = 2005;
    }
}
