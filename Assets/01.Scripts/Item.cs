using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item
{
    [SerializeField] string weapon_Name;
    [SerializeField] Sprite weapon_Img;
    [SerializeField] float weapon_Dmg,weapon_Def,weapon_AtkSpd, weapon_IncomePercent, weapon_DmgPercent, weapon_ExpPercent;
    [SerializeField] int weapon_Price, weapon_UpgradeCost, weapon_Level, weapon_MaxLevel, weapon_Rank, weapon_Code, weapon_Type;
    [SerializeField] bool weapon_Equip;
    public Item(string _weapon_Name, float _weapon_Dmg,float _weapon_Def, float _weapon_AtkSpd, float _weapon_IncomePercent, float _weapon_DmgPercent, float _weapon_ExpPercent,
    int _weapon_Price, int _weapon_UpgradeCost, int _weapon_Level, int _weapon_MaxLevel, int _weapon_Rank, int _weapon_Code,int _weapon_Type, bool _weapon_Equip = false, Sprite _weapon_Img = null){
        weapon_Name = _weapon_Name;
        weapon_Dmg = _weapon_Dmg;
        weapon_Def = _weapon_Def;
        weapon_AtkSpd = _weapon_AtkSpd;
        weapon_IncomePercent = _weapon_IncomePercent;
        weapon_ExpPercent = _weapon_ExpPercent;
        weapon_Price = _weapon_Price;
        weapon_UpgradeCost = _weapon_UpgradeCost;
        weapon_Level = _weapon_Level;
        weapon_MaxLevel = _weapon_MaxLevel;
        weapon_Rank = _weapon_Rank;
        weapon_Code = _weapon_Code;
        weapon_Type = _weapon_Type;
        weapon_Equip = _weapon_Equip;
    }


    //Getter
    public string Get_weapon_Name(){
        return weapon_Name;
    }
    public float Get_weapon_Dmg(){
        return weapon_Dmg;
    }
    public float Get_weapon_Def(){
        return weapon_Def;
    }
    public float Get_weapon_AtkSpd(){
        return weapon_AtkSpd;
    }
    public float Get_weapon_IncomePercent(){
        return weapon_IncomePercent;
    }
    public float Get_weapon_DmgPercent(){
        return weapon_DmgPercent;
    }
    public float Get_weapon_ExpPercent(){
        return weapon_ExpPercent;
    }
    public int Get_weapon_Price(){
        return weapon_Price;
    }
    public int Get_weapon_UpgradeCost(){
        return weapon_UpgradeCost;
    }
    public int Get_weapon_Level(){
        return weapon_Level;
    }
    public int Get_weapon_MaxLevel(){
        return weapon_MaxLevel;
    }
    public int Get_weapon_Rank(){
        return weapon_Rank;
    }
    public int Get_weapon_Code(){
        return weapon_Code;
    }
    public bool Get_weapon_Equip(){
        return weapon_Equip;
    }
    public Sprite Get_weapon_Img(){
        return weapon_Img;
    }
    public int Get_weapon_Type(){
        return weapon_Type;
    }
    //setter
    public void Set_weapon_Name(string _weapon_Name){
        weapon_Name = _weapon_Name;
    }
    public void Set_weapon_Dmg(float _weapon_Dmg){
        weapon_Dmg = _weapon_Dmg;
    }
    public void Set_weapon_Def(float _weapon_Def){
        weapon_Def = _weapon_Def;
    }
    public void Set_weapon_AtkSpd(float _weapon_AtkSpd){
        weapon_AtkSpd = _weapon_AtkSpd;
    }
    public void Set_weapon_IncomePercent(float _weapon_IncomePercent){
        weapon_IncomePercent = _weapon_IncomePercent;
    }
    public void Set_weapon_DmgPercent(float _weapon_DmgPercent){
        weapon_DmgPercent = _weapon_DmgPercent;
    }
    public void Set_weapon_ExpPercent(float _weapon_ExpPercent){
        weapon_ExpPercent = _weapon_ExpPercent;
    }
    public void Set_weapon_Price(int _weapon_Price){
        weapon_Price = _weapon_Price;
    }
    public void Set_weapon_UpgradeCost(int _weapon_UpgradeCost){
        weapon_UpgradeCost = _weapon_UpgradeCost;
    }
    public void Set_weapon_Level(int _weapon_Level){
        weapon_Level = _weapon_Level;
    }
    public void Set_weapon_MaxLevel(int _weapon_MaxLevel){
        weapon_MaxLevel = _weapon_MaxLevel;
    }
    public void Set_weapon_Rank(int _weapon_Rank){
        weapon_Rank = _weapon_Rank;
    }
    public void Set_weapon_Code(int _weapon_Code){
        weapon_Code = _weapon_Code;
    }
    public void Set_weapon_Equip(bool _weapon_Equip){
        weapon_Equip = _weapon_Equip;
    }
    public void Set_weapon_Type(int _weapon_Type){
        weapon_Type = _weapon_Type;
    }

    static public string Show_wepon_Info(Item item){
        string str = item.Get_weapon_Name() + "\n"+
        "랭크"+ "\t" + item.Get_weapon_Rank()+"\n"+
        "공격력"+ "\t"+ item.Get_weapon_Dmg()+"\n"+
        "방어력"+ "\t"+ item.Get_weapon_Def()+"\n"+
        "공격속도"+ "\t"+ item.Get_weapon_AtkSpd()+"\n"+
        "~~~~~~~~~~~~~~\n" + "부스텟 \n"+
        "데미지증가량"+ "\t" + item.Get_weapon_DmgPercent()+"\n"+
        "경험치증가량"+ "\t" + item.Get_weapon_ExpPercent()+"\n"+
        "코인증가량" + item.Get_weapon_IncomePercent()+"\n";

        return str;
    }
}
