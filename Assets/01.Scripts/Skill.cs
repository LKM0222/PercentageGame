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
    //effect아직 추가 x
    
    public Skill(string _name, string _info, int _code, float _time){
        skillName = _name;
        skillInfo = _info;
        skillCode = _code;
        skillTime = _time;
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
}
