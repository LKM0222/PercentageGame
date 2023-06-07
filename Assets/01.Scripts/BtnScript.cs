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


    //inven
    //[SerializeField] int slotCount;
    QuestionPopup theQuestionPopup;
    
    DataBase theDB;

    private void Awake() {
        theDB = FindObjectOfType<DataBase>();
        theQuestionPopup = FindObjectOfType<QuestionPopup>();
        
    }
    private void Start() {

        if(this.transform.parent.gameObject.tag == "InvenSlot"){
           // slotCount = this.transform.parent.GetComponent<InvenSlot>().count;
        }
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
    
        statInfo.text = code.ToString() + "설명 들어갈곳!";
    }

    public void OnInventorySlotBtn(){
        var parents = this.transform.parent.transform.parent.transform.parent.transform.parent.transform.parent.transform.parent.transform.parent;
        var child = parents.gameObject.transform.GetChild(3);
        child.gameObject.SetActive(true);
        theDB.slotCount = this.transform.parent.GetComponent<InvenSlot>().count;
    }

    public void OnWeaponMountingBtnClick(){
        
    }
    public void OnWeaponClearBtnClick(){
        
    }
    public void OnWeaponDestoryBtnClick(){
        theDB.inventoryList.RemoveAt(theDB.slotCount);
        Destroy(theQuestionPopup.content.transform.GetChild(theDB.slotCount).gameObject);
    }
}
