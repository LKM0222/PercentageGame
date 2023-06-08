using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnScript : MonoBehaviour
{
    //UI
    [SerializeField] GameObject logScrollview;
    [SerializeField] GameObject statScrollview;

    //Equipment
    [SerializeField] Text statInfo;
    PlayerStatus thePlayer;


    //inven
    //[SerializeField] int slotCount;
    QuestionPopup theQuestionPopup;
    
    DataBase theDB;

    private void Awake() {
        theDB = FindObjectOfType<DataBase>();
        theQuestionPopup = FindObjectOfType<QuestionPopup>();
        thePlayer = FindObjectOfType<PlayerStatus>();
        
    }
    private void Start() {

    }

    // test
    public void OnTestBtn(){
        print("test!!");
    }

    public void OnStatBtnClick(){
        logScrollview.SetActive(false);
        statScrollview.SetActive(true);
    }

    public void OnLogBtnClick(){
        logScrollview.SetActive(true);
        statScrollview.SetActive(false);
    }

    public void OnEquipSlotBtnClick(){
        int code = this.transform.parent.GetComponent<EquipSlotInfo>().equipSlotCode;
        switch(code){
            case 1001:
                if(theDB.equipWeponList[0].Get_weapon_Code() == 0){
                    statInfo.text = "아이템이 없습니다!";
                }
                else statInfo.text = Item.Show_wepon_Info(theDB.equipWeponList[0]);
                break;
            case 1002:
                if(theDB.equipWeponList[1].Get_weapon_Code() == 0){
                    statInfo.text = "아이템이 없습니다!";
                }
                else statInfo.text = Item.Show_wepon_Info(theDB.equipWeponList[1]);
                break;
            case 1003:
                if(theDB.equipWeponList[2].Get_weapon_Code() == 0){
                    statInfo.text = "아이템이 없습니다!";
                }
                else statInfo.text = Item.Show_wepon_Info(theDB.equipWeponList[2]);
                break;  
            case 1004:
                if(theDB.equipWeponList[3].Get_weapon_Code() == 0){
                    statInfo.text = "아이템이 없습니다!";
                }
                else statInfo.text = Item.Show_wepon_Info(theDB.equipWeponList[3]);
                break;
            case 1005:
                if(theDB.equipWeponList[4].Get_weapon_Code() == 0){
                    statInfo.text = "아이템이 없습니다!";
                }
                else statInfo.text = Item.Show_wepon_Info(theDB.equipWeponList[4]);
                break;

            default:
                break;
        }
    }

    public void OnInventorySlotBtn(){
        var parents = this.transform.parent.transform.parent.transform.parent.transform.parent.transform.parent.transform.parent.transform.parent;
        var child = parents.gameObject.transform.GetChild(3);
        child.gameObject.SetActive(true);
        theDB.slotCount = this.transform.parent.GetComponent<InvenSlot>().count;
    }

    public void OnWeaponMountingBtnClick(){
        //부위별로 아이템 검색해야됨
        //장착중인 아이템을 해제 시키고 장착할 아이템을 넣는다.
        Item item = theDB.inventoryList[theDB.slotCount]; //선택한 아이템
        switch(item.Get_weapon_Type()){
            case 1001: //머리
                if(theDB.equipWeponList[0].Get_weapon_Code() != 0){ //0이 아닐 경우 -> 아이템 장착중, 0일경우-> 아이템없음
                    theDB.inventoryList[theDB.inventoryList.FindIndex(x => x.Get_weapon_Code() == theDB.equipWeponList[0].Get_weapon_Code())].Set_weapon_Equip(false);
                    theDB.inventoryList[theDB.slotCount].Set_weapon_Equip(true);
                    theDB.equipWeponList[0] = theDB.inventoryList[theDB.slotCount];
                }
                else{
                    theDB.equipWeponList[0] = theDB.inventoryList[theDB.slotCount];
                    theDB.inventoryList[theDB.slotCount].Set_weapon_Equip(true);
                }
                break;
            case 1002: //몸통
                if(theDB.equipWeponList[1].Get_weapon_Code() != 0){ //0이 아닐 경우 -> 아이템 장착중, 0일경우-> 아이템없음
                    theDB.inventoryList[theDB.inventoryList.FindIndex(x => x.Get_weapon_Code() == theDB.equipWeponList[1].Get_weapon_Code())].Set_weapon_Equip(false);
                    theDB.inventoryList[theDB.slotCount].Set_weapon_Equip(true);
                    theDB.equipWeponList[1] = theDB.inventoryList[theDB.slotCount];
                }
                else{
                    theDB.equipWeponList[1] = theDB.inventoryList[theDB.slotCount];
                    theDB.inventoryList[theDB.slotCount].Set_weapon_Equip(true);
                }
                break;
            case 1003: //바지
                if(theDB.equipWeponList[2].Get_weapon_Code() != 0){ //0이 아닐 경우 -> 아이템 장착중, 0일경우-> 아이템없음
                    theDB.inventoryList[theDB.inventoryList.FindIndex(x => x.Get_weapon_Code() == theDB.equipWeponList[2].Get_weapon_Code())].Set_weapon_Equip(false);
                    theDB.inventoryList[theDB.slotCount].Set_weapon_Equip(true);
                    theDB.equipWeponList[2] = theDB.inventoryList[theDB.slotCount];
                }
                else{
                    theDB.equipWeponList[2] = theDB.inventoryList[theDB.slotCount];
                    theDB.inventoryList[theDB.slotCount].Set_weapon_Equip(true);
                }
                break;
            case 1004: //신발
                if(theDB.equipWeponList[3].Get_weapon_Code() != 0){ //0이 아닐 경우 -> 아이템 장착중, 0일경우-> 아이템없음
                    theDB.inventoryList[theDB.inventoryList.FindIndex(x => x.Get_weapon_Code() == theDB.equipWeponList[3].Get_weapon_Code())].Set_weapon_Equip(false);
                    theDB.inventoryList[theDB.slotCount].Set_weapon_Equip(true);
                    theDB.equipWeponList[3] = theDB.inventoryList[theDB.slotCount];
                }
                else{
                    theDB.equipWeponList[3] = theDB.inventoryList[theDB.slotCount];
                    theDB.inventoryList[theDB.slotCount].Set_weapon_Equip(true);
                }
                break;
            case 1005: //무기
                if(theDB.equipWeponList[4].Get_weapon_Code() != 0){ //0이 아닐 경우 -> 아이템 장착중, 0일경우-> 아이템없음
                    theDB.inventoryList[theDB.inventoryList.FindIndex(x => x.Get_weapon_Code() == theDB.equipWeponList[4].Get_weapon_Code())].Set_weapon_Equip(false);
                    theDB.inventoryList[theDB.slotCount].Set_weapon_Equip(true);
                    theDB.equipWeponList[4] = theDB.inventoryList[theDB.slotCount];
                }
                else{
                    theDB.equipWeponList[4] = theDB.inventoryList[theDB.slotCount];
                    theDB.inventoryList[theDB.slotCount].Set_weapon_Equip(true);
                }
                break;
        }
    }
    public void OnWeaponClearBtnClick(){
        theDB.inventoryList[theDB.slotCount].Set_weapon_Equip(false);
        Item item = theDB.inventoryList[theDB.slotCount]; //선택한 아이템
        switch(item.Get_weapon_Type()){
            case 1001:
                thePlayer.equip_item_head = DataBase.nullItem;
                theDB.equipWeponList[0] = DataBase.nullItem;
                break;
            case 1002:
                thePlayer.equip_item_body = DataBase.nullItem;
                theDB.equipWeponList[1] = DataBase.nullItem;
                break;
            case 1003:
                thePlayer.equip_item_pants = DataBase.nullItem;
                theDB.equipWeponList[2] = DataBase.nullItem;
                break;
            case 1004:
                thePlayer.equip_item_shoose = DataBase.nullItem;
                theDB.equipWeponList[3] = DataBase.nullItem;
                break;
            case 1005:
                thePlayer.equip_item_weapon = DataBase.nullItem;
                theDB.equipWeponList[4] = DataBase.nullItem;
                break;
        }
    }
    public void OnWeaponDestoryBtnClick(){ //아이템 삭제하고 나서 아이템 장착해제 할것, 또한 장비창에서 아이템 이미지 제거할것.
        theDB.inventoryList.RemoveAt(theDB.slotCount);
        Destroy(theQuestionPopup.content.transform.GetChild(theDB.slotCount).gameObject);
    }



    
}
