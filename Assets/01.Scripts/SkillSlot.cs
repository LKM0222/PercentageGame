using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//스킬창에 스킬 슬롯들에 붙어있는 스크립트
public class SkillSlot : MonoBehaviour
{
    DataBase theDB;
    [SerializeField] Skill skill;

    private void Update() {
        //일단 가져와야할것.
        this.GetComponent<Image>().sprite = skill.Get_Skill_Img();
        //레벨은 수시로 변경되니 다른곳에 넣어야될듯.
        
        this.transform.GetChild(0).GetComponent<Text>().text = "+" + skill.Get_Skill_Level().ToString();
        
    }

    public void SetSkill(Skill _skill){
        skill = _skill;
    }

    public Skill GetSkill(){
        return skill;
    }
}
