using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBase : MonoBehaviour
{
    public int playerLevel, playerRank;

    public float finalDmg;

    public float Atk;
    public float defense;
    public float atkSpd; //defalut = 2.5, max = 0.1 (수정할수도 있음)

    public int Rank;

    public float incomePercent, dmgPercent, expPercent;

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
        // equipWeponList[0] = inventoryList[
        // inventoryList.FindIndex(x=> x.Get_weapon_Code() == equipWeponList[0].Get_weapon_Code())];
        
    }



}
