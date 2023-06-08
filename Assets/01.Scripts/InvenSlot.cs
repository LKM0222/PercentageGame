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

    public Image itemImg;
    public Text itemName;
    public GameObject equipImg;
    public Item item;

    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<DataBase>();
        theInventorySystem = FindObjectOfType<InventorySystem>();

        itemCode = item.Get_weapon_Code();
    }

    // Update is called once per frame
    void Update()
    { 
        count = theDB.inventoryList.IndexOf(item);
        itemImg.sprite = item.Get_weapon_Img();
        itemName.text = item.Get_weapon_Name();
        if(item.Get_weapon_Equip()){
            equipImg.SetActive(true);
        }
        else{
            equipImg.SetActive(false);
        }        
    }
}
