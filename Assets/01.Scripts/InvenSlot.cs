using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvenSlot : MonoBehaviour
{
    DataBase theDB;
    InventorySystem theInventorySystem;
    public int count;
    public int itemCode;

    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<DataBase>();
        theInventorySystem = FindObjectOfType<InventorySystem>();
    }

    // Update is called once per frame
    void Update()
    { 
        //리스트의 길이가 변함에 따라 슬롯의 카운트도 같이 변해야됨...
        count = theDB.inventoryList.IndexOf(itemCode);

        try{
            this.transform.GetChild(0).transform.GetChild(0).GetComponent<Image>().sprite = 
                theDB.FindItemCodeReturnImg(theDB.inventoryList[count]);
            this.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = 
                theDB.FindItemCodeReturnName(theDB.inventoryList[count]);
            if(theDB.FindItemCodeReturnEquip(theDB.inventoryList[count])){
                this.transform.GetChild(1).gameObject.SetActive(true);
            }
            else{
                this.transform.GetChild(1).gameObject.SetActive(false);
            }
        }catch(System.IndexOutOfRangeException){
            print("item Destory!");
        }

        
    }
}
