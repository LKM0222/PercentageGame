using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스킬창에 스킬 슬롯들에 붙어있는 스크립트
public class SkillSlot : MonoBehaviour
{
    DataBase theDB;
    [SerializeField] Skill skill;

    public void SetSkill(Skill _skill){
        skill = _skill;
    }

    public Skill GetSkill(){
        return skill;
    }
}
