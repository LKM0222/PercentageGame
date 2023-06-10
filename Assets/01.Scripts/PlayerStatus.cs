using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//플레이어의 현재 상태 (어떤 장비를 착용중인지, ...)
//착용중인 장비의 코드를 가져오자.
public class PlayerStatus : MonoBehaviour
{
    public int playerLevel, playerRank;
    public int playerExp, playerMaxExp;
    public int playerCoin;


    public float finalDmg;
    

    public float Atk; //능력치로 결정되는 플레이어의 기본 공격력
    public float defense;
    public float atkSpd; //defalut = 2.5, max = 0.1 (수정할수도 있음)

    public float incomePercent, dmgPercent, expPercent;
    public Item equip_item_head, equip_item_body, equip_item_pants, equip_item_shoose, equip_item_weapon;

    DataBase theDB;
    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<DataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        equip_item_head = theDB.equipWeponList[0];
        equip_item_body = theDB.equipWeponList[1];
        equip_item_pants = theDB.equipWeponList[2];
        equip_item_shoose = theDB.equipWeponList[3];
        equip_item_weapon = theDB.equipWeponList[4];
        
        finalDmg = SetFinalDmg();
    }

    public float SetFinalDmg(){
        float Playerdmg = Atk;
        float SumEquipdmg = 
        equip_item_head.Get_weapon_Dmg() + 
        equip_item_body.Get_weapon_Dmg() + 
        equip_item_pants.Get_weapon_Dmg() +
        equip_item_shoose.Get_weapon_Dmg() +
        equip_item_weapon.Get_weapon_Dmg();

        dmgPercent =
        equip_item_head.Get_weapon_DmgPercent() + 
        equip_item_body.Get_weapon_DmgPercent() + 
        equip_item_pants.Get_weapon_DmgPercent() +
        equip_item_shoose.Get_weapon_DmgPercent() +
        equip_item_weapon.Get_weapon_DmgPercent();

        //(플레이어의 스텟 공격력 + 착용중인 아이템들이 가진 공격력) * (1 + 아이템들이 갖고잇는 데미지 추가퍼센트)
        return (Playerdmg + SumEquipdmg) * (1 + dmgPercent);
    }


    public bool AttackFlag(){
        if(equip_item_weapon.Get_weapon_Equip()){
            return true;
        }
        else return false;
    }
}
