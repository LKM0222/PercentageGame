using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBase : MonoBehaviour
{
    

    static public Item nullItem = new Item("",0,0,0,0,0,0,0,0,0,0,0,0,0);

    public List<Item> itemList = new List<Item>();


    //inven
    public List<Item> inventoryList = new List<Item>();
    public Item[] equipWeponList = new Item[5];
    public int slotCount; //인벤토리에서 몇번째 아이템인지 
    
    private void Update()
    {
        ItemUpdate();
    }
    public void ItemUpdate(){
        // print(inventoryList.FindIndex(x=> x.Get_weapon_Code() == equipWeponList[0].Get_weapon_Code()));
        // inventoryList[inventoryList.FindIndex(x=> x.Get_weapon_Code() == equipWeponList[0].Get_weapon_Code())] = equipWeponList[0];

    }



}
