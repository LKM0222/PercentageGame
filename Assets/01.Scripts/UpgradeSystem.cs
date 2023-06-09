using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//업그레이드 시스템은 코드상 분류해야함
//장착중인 아이템 -> equipWeponList에서 가져와야됨
//장착중이지 않은 아이템 -> inventoryList에서 가져와야됨
public class UpgradeSystem : MonoBehaviour
{
    DataBase theDB;
    PlayerStatus thePlayer;

    //UI
    [Header("텍스트")]
    [SerializeField] Text weapon_nameText;
    [SerializeField] Text wepon_levelText;
    [SerializeField] Text source1Text;
    [SerializeField] Text source2Text;
    [SerializeField] Text source1Name;
    [SerializeField] Text source2Name;
    [SerializeField] Text coinText;
    [SerializeField] Text costText;
    [Header("이미지")]
    [SerializeField] Image weaponImg;
    [SerializeField] Image source1Img;
    [SerializeField] Image source2Img;
    [SerializeField] Image weaponRankImg;
    [Header("Befor Text")]
    [SerializeField] Text befor_Dmg;
    [SerializeField] Text befor_Def;
    [SerializeField] Text befor_AtkSpd;
    [SerializeField] Text befor_Income;
    [SerializeField] Text befor_DmgPercent;
    [SerializeField] Text befor_ExpPercent;
    [Header("After Text")]
    [SerializeField] Text After_Dmg;
    [SerializeField] Text After_Def;
    [SerializeField] Text After_AtkSpd;
    [SerializeField] Text After_Income;
    [SerializeField] Text After_DmgPercent;
    [SerializeField] Text After_ExpPercent;
    [Header("상승, 하강 화살표")]
    [SerializeField] Image dmg_Arrow;
    [SerializeField] Image def_Arrow;
    [SerializeField] Image atkspd_Arrow;
    [SerializeField] Image income_Arrow;
    [SerializeField] Image dmgPercent_Arrow;
    [SerializeField] Image expPercent_Arrow;

    [Header("화살표 이미지")]
    [SerializeField] Sprite upArrow;
    [SerializeField] Sprite downArrow;
    [SerializeField] Sprite arrow;

    int num = 100;
    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<DataBase>();
        thePlayer = FindObjectOfType<PlayerStatus>();
    }
    private void Update() {
        if(theDB.inventoryList[theDB.slotCount].Get_weapon_Equip()){
            switch(theDB.inventoryList[theDB.slotCount].Get_weapon_Type()){
                case 1001:
                    UIUpdate(theDB.equipWeponList[0]);
                    break;
                case 1002:
                    UIUpdate(theDB.equipWeponList[1]);
                    break;
                case 1003:
                    UIUpdate(theDB.equipWeponList[2]);
                    break;
                case 1004:
                    UIUpdate(theDB.equipWeponList[3]);
                    break;
                case 1005:
                    UIUpdate(theDB.equipWeponList[4]);
                    break;
            }
        }
        else{
            UIUpdate(theDB.inventoryList[theDB.slotCount]);
        }
    }
    
    public void Upgrade(Item item){
        item.Set_weapon_Dmg(item.Get_weapon_Dmg() + num);
        item.Set_weapon_Level(item.Get_weapon_Level() + 1);
    }
    void UIUpdate(Item item){
        weapon_nameText.text = item.Get_weapon_Name();
        wepon_levelText.text = "+"+item.Get_weapon_Level().ToString();
        weaponImg.sprite = item.Get_weapon_Img(); 
    }
    public void UpdateBeforInfoText(Item _beforItem){
        befor_Dmg.text = _beforItem.Get_weapon_Dmg().ToString();
        befor_Def.text = _beforItem.Get_weapon_Def().ToString();
        befor_AtkSpd.text = _beforItem.Get_weapon_AtkSpd().ToString();
        befor_Income.text = _beforItem.Get_weapon_IncomePercent().ToString();
        befor_DmgPercent.text = _beforItem.Get_weapon_DmgPercent().ToString();
        befor_ExpPercent.text = _beforItem.Get_weapon_ExpPercent().ToString();
        
    }
    public void UpdateAfterInfoText(Item _afterItem){
        After_Dmg.text = _afterItem.Get_weapon_Dmg().ToString();
        After_Def.text = _afterItem.Get_weapon_Def().ToString();
        After_AtkSpd.text = _afterItem.Get_weapon_AtkSpd().ToString();
        After_Income.text = _afterItem.Get_weapon_IncomePercent().ToString();
        After_DmgPercent.text = _afterItem.Get_weapon_DmgPercent().ToString();
        After_ExpPercent.text = _afterItem.Get_weapon_ExpPercent().ToString();
    
    }
    public void UpdateAfterInfoTextSetZero(){
        After_Dmg.text = "-";
        After_Def.text = "-";
        After_AtkSpd.text = "-";
        After_Income.text = "-";
        After_DmgPercent.text = "-";
        After_ExpPercent.text = "-";

        dmg_Arrow.sprite = arrow;
        def_Arrow.sprite = arrow;
        atkspd_Arrow.sprite = arrow;
        income_Arrow.sprite = arrow;
        dmgPercent_Arrow.sprite = arrow;
        expPercent_Arrow.sprite = arrow;
    }

    public void UpdateArrowImg(){
        dmg_Arrow.sprite = arrowImg(float.Parse(befor_Dmg.text),float.Parse(After_Dmg.text));
        def_Arrow.sprite = arrowImg(float.Parse(befor_Def.text),float.Parse(After_Def.text));
        atkspd_Arrow.sprite = arrowImg(float.Parse(befor_AtkSpd.text),float.Parse(After_AtkSpd.text));
        income_Arrow.sprite = arrowImg(float.Parse(befor_Income.text),float.Parse(After_Income.text));
        dmgPercent_Arrow.sprite = arrowImg(float.Parse(befor_DmgPercent.text),float.Parse(After_DmgPercent.text));
        expPercent_Arrow.sprite = arrowImg(float.Parse(befor_ExpPercent.text),float.Parse(After_ExpPercent.text));
    }

    Sprite arrowImg(float _befor, float _after){
        if(_befor < _after){
            return upArrow;
        }
        else if(_befor > _after){
            return downArrow;
        }
        else{
            return arrow;
        }
    }
}
