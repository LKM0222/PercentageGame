using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//플레이어의 현재 상태 (어떤 장비를 착용중인지, ...)
//착용중인 장비의 코드를 가져오자.
public class PlayerStatus : MonoBehaviour
{
    

    
    DataBase theDB;

    RaycastHit2D hit;

    public LayerMask layer;

    public bool atkFlag = true;

    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<DataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        hit = Physics2D.Raycast(this.transform.position, Vector3.right * 3f, theDB.atkDistance,layer);
        if(!hit){//Enemy를 감지하지 않은 경우만 이동
            this.transform.Translate(Vector3.right * theDB.playerSpeed * Time.deltaTime);
            atkFlag = false;
        }
        else{
            atkFlag = true;
        }
        

        theDB.equip_item_head = theDB.equipWeponList[0];
        theDB.equip_item_body = theDB.equipWeponList[1];
        theDB.equip_item_pants = theDB.equipWeponList[2];
        theDB.equip_item_shoose = theDB.equipWeponList[3];
        theDB.equip_item_weapon = theDB.equipWeponList[4];
        
        theDB.finalDmg = SetFinalDmg();
    }

    public float SetFinalDmg(){
        float Playerdmg = theDB.Atk;
        float SumEquipdmg = 
        theDB.equip_item_head.Get_weapon_Dmg() + 
        theDB.equip_item_body.Get_weapon_Dmg() + 
        theDB.equip_item_pants.Get_weapon_Dmg() +
        theDB.equip_item_shoose.Get_weapon_Dmg() +
        theDB.equip_item_weapon.Get_weapon_Dmg();

        theDB.dmgPercent =
        theDB.equip_item_head.Get_weapon_DmgPercent() + 
        theDB.equip_item_body.Get_weapon_DmgPercent() + 
        theDB.equip_item_pants.Get_weapon_DmgPercent() +
        theDB.equip_item_shoose.Get_weapon_DmgPercent() +
        theDB.equip_item_weapon.Get_weapon_DmgPercent();

        //(플레이어의 스텟 공격력 + 착용중인 아이템들이 가진 공격력) * (1 + 아이템들이 갖고잇는 데미지 추가퍼센트)
        return (Playerdmg + SumEquipdmg) * (1 + theDB.dmgPercent);
    }


    public bool PlayerEquipFlag(){
        if(theDB.equip_item_weapon.Get_weapon_Equip()){
            return true;
        }
        else return false;
    }

    


}
