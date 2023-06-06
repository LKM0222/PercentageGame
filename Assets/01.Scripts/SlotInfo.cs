using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotInfo : MonoBehaviour
{
    //현재 슬롯에 장착 된 아이템의 성능 및 상태 저장

    public int equipSlotCode;//1001 모자, 1002 옷, 1003 바지, 1004 신발, 1005 무기
    public int equipItemCode;

    PlayerStatus thePlayerStatus;
    DataBase theDB;
    // Start is called before the first frame update
    void Start()
    {
        thePlayerStatus = FindObjectOfType<PlayerStatus>();
        theDB = FindObjectOfType<DataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(equipSlotCode){
            case 1001://head
                equipItemCode = thePlayerStatus.equip_item_head;
                this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = theDB.itemSprite[0];
                break;

            case 1002://body
                equipItemCode = thePlayerStatus.equip_item_body;
                this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = theDB.itemSprite[1];
                break;

            case 1003://pants
                equipItemCode = thePlayerStatus.equip_item_pants;
                this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = theDB.itemSprite[2];
                break;

            case 1004://shoose
                equipItemCode = thePlayerStatus.equip_item_shoose;
                this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = theDB.itemSprite[3];
                break;

            case 1005://weapon
                equipItemCode = thePlayerStatus.equip_item_weapon;
                this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = theDB.itemSprite[4];
                break;
        }
    }
}
