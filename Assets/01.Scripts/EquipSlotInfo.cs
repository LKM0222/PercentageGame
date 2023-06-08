using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipSlotInfo : MonoBehaviour
{
    //현재 슬롯에 장착 된 아이템의 성능 및 상태 저장

    public int equipSlotCode;//1001 모자, 1002 옷, 1003 바지, 1004 신발, 1005 무기
    [SerializeField] Image slotImg;
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
        //이미지만 띄워주는 용도, 아이템 관리는 인벤토리에서 진행
        switch(equipSlotCode){
            case 1001://head
                this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite 
                    = thePlayerStatus.equip_item_head.Get_weapon_Img();
                break;

            case 1002://body
                this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite 
                    = thePlayerStatus.equip_item_body.Get_weapon_Img();
                break;

            case 1003://pants
                this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite 
                    = thePlayerStatus.equip_item_pants.Get_weapon_Img();
                break;

            case 1004://shoose
                this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite 
                    = thePlayerStatus.equip_item_shoose.Get_weapon_Img();
                break;

            case 1005://weapon
                this.gameObject.transform.GetChild(0).GetComponent<Image>().sprite 
                    = thePlayerStatus.equip_item_weapon.Get_weapon_Img();
                break;
        }
    }
}
