using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Skill
{
    [SerializeField] string skillName,skillInfo;
    [SerializeField] int skillCode;
    [SerializeField] float skillTime;
    [SerializeField] Sprite skillImg;
    [SerializeField] bool skillEquip;
    [SerializeField] bool skillLearn;
    [SerializeField] int skillUpgradeCost;

    //effect아직 추가 x
    
    public Skill(string _name, string _info, int _code, float _time,bool _equip, bool _learn, int _upgradeCost){
        skillName = _name;
        skillInfo = _info;
        skillCode = _code;
        skillTime = _time;
        skillEquip = _equip;
        skillLearn = _learn;
        skillUpgradeCost = _upgradeCost;
    }

    //getter
    public string Get_Skill_Name(){
        return skillName;
    }
    public string Get_Skill_Info(){
        return skillInfo;
    }
    public int Get_Skill_Code(){
        return skillCode;
    }
    public float Get_Skill_Time(){
        return skillTime;
    }
    public Sprite Get_Skill_Img(){
        return skillImg;
    }

    public bool Get_Skill_Equip(){
        return skillEquip;
    }

    public bool Get_Skill_Learn(){
        return skillLearn;
    }

    public int Get_Skill_UpgradeCost(){
        return skillUpgradeCost;
    }


    //setter
    public void Set_Skill_Name(string _name){
        skillName = _name;
    }
    public void Set_Skill_Info(string _info){
        skillInfo = _info;
    }
    public void Set_Skill_Code(int _code){
        skillCode = _code;
    }
    public void Set_Skill_Time(float _time){
        skillTime = _time;
    }

    public void Set_Skill_Equip(bool _equip){
        skillEquip = _equip;
    }

    public void Set_Skill_Learn(bool _learn){
        skillLearn = _learn;
    }

    public void Set_Skill_UpgradeCost(int _cost){
        skillUpgradeCost = _cost;
    }
}
