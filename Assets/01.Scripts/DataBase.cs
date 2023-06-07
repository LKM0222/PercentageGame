using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBase : MonoBehaviour
{
    public float dmg;
    public float atkSpd; //defalut = 2.5, max = 0.1 (수정할수도 있음)

    public Item[] itemList = new Item[0];


    //inven
    public List<int> inventoryList = new List<int>();
    public int slotCount;


    public Sprite FindItemCodeReturnImg(int _itemCode){
        for(int i = 0;i<itemList.Length;i++){
            if(itemList[i].Get_weapon_Code() == _itemCode){
                return itemList[i].Get_weapon_Img();
            }
        }
        return null;
    }

    public string FindItemCodeReturnName(int _itemCode){
        for(int i = 0;i<itemList.Length;i++){
            if(itemList[i].Get_weapon_Code() == _itemCode){
                return itemList[i].Get_weapon_Name();
            }
        }
        return "Error";
    }
    public bool FindItemCodeReturnEquip(int _itemCode){
        for(int i = 0;i<itemList.Length;i++){
            if(itemList[i].Get_weapon_Code() == _itemCode){
                return itemList[i].Get_weapon_Equip();
            }
        }
        return false;
    }

    public void FindItemCodeSetEquip(int _itemCode,bool _item_status){
        for(int i = 0;i<itemList.Length;i++){
            if(itemList[i].Get_weapon_Code() == _itemCode){
                itemList[i].Set_weapon_Equip(_item_status);
            }
        }
    }
}
