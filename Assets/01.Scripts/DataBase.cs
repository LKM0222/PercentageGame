using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBase : MonoBehaviour
{
    
    public int slotCount; //인벤토리에서 몇번째 아이템인지 
    public int skillCode;

    static public Item nullItem = new Item("",0,0,0,0,0,0,0,0,0,0,0,0,0);

    public List<Item> itemList = new List<Item>();
    public List<Enemy> enemyList = new List<Enemy>();
    public List<Skill> skillList = new List<Skill>();

    //inven
    public List<Item> inventoryList = new List<Item>();
    public Item[] equipWeponList = new Item[5];
    
    
    //enemy
    public List<Enemy> spawnEnemyList = new List<Enemy>();

    //skill
    public List<Skill> equipedSkill = new List<Skill>();
    public List<Skill> skillInUse = new List<Skill>();


    //log
    public List<GameObject> logList = new List<GameObject>();
    
    public static DataBase Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        ItemUpdate();        
    }
    public void ItemUpdate(){
        //인벤토리에서 장착된 아이템은 아이템 타입 코드를 불러와서 이큅에 적용해야됨...
        List<Item> i = inventoryList.FindAll(x => x.Get_weapon_Equip() == true);
        for(int j = 0;j < i.Count;j++)
            ItemEquip(i[j]);
    }
    void ItemEquip(Item _equipItem){
        switch(_equipItem.Get_weapon_Type()){
            case 1001:
                equipWeponList[0] = _equipItem;
                break;
            case 1002:
                equipWeponList[1] = _equipItem;
                break;
            case 1003:
                equipWeponList[2] = _equipItem;
                break;
            case 1004:
                equipWeponList[3] = _equipItem;
                break;
            case 1005:
                equipWeponList[4] = _equipItem;
                break;
        }
    }



}
