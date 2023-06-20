using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBase : MonoBehaviour
{
    
    

    public List<Item> itemList = new List<Item>();
    public List<Enemy> enemyList = new List<Enemy>();

    //inven
    [Header("Inventory")]
    public List<Item> inventoryList = new List<Item>();
    public Item[] equipWeponList = new Item[5];
    
    
    //enemy
    [Header("Enemy")]
    public List<Enemy> spawnEnemyList = new List<Enemy>();

    //skill
    [Header("Skill")]
    public List<Skill> skillList = new List<Skill>();
    public List<Skill> equipedSkill = new List<Skill>();
    public List<Skill> skillInUse = new List<Skill>();


    //log
    [Header("Log")]
    public List<GameObject> logList = new List<GameObject>();

    //scene
    [Header("Scene")]
    public int sceneCode;

    //player
    [Header("Player")]
    public int playerLevel, playerRank;
    public int playerExp, playerMaxExp;
    public int playerCoin;
    public float finalDmg;
    public float Atk; //능력치로 결정되는 플레이어의 기본 공격력
    public float defense;
    public float atkSpd; //defalut = 2.5, max = 0.1 (수정할수도 있음)
    public float atkDistance;
    public float playerSpeed;
    public float incomePercent, dmgPercent, expPercent;
    public Item equip_item_head, equip_item_body, equip_item_pants, equip_item_shoose, equip_item_weapon;

    [Header("ETC")]
    public int slotCount; //인벤토리에서 몇번째 아이템인지 
    public int skillCode;

    static public Item nullItem = new Item("",0,0,0,0,0,0,0,0,0,0,0,0,0);

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
