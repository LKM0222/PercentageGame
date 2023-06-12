using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBtn : MonoBehaviour
{
    public int skillCode;
    DataBase theDB;

    [SerializeField] GameObject skillImgSpawner;
    public GameObject skillIcon;

    private void Awake()
    {
        theDB = FindObjectOfType<DataBase>();
        skillImgSpawner = GameObject.Find("SkillTimer");
    }
    public void OnSkillBtnClikc(){
        //여기서 검색, 리스트에 추가
        if(theDB.skillInUse.Find(x => x.Get_Skill_Code() == skillCode) == null){
            if(theDB.equipedSkill.Find(x => x.Get_Skill_Code() == skillCode) != null){
                print("스킬사용중이 아님! 스킬 추가");
                var skill = Instantiate(skillIcon,skillImgSpawner.transform.position,Quaternion.identity,skillImgSpawner.transform);
                theDB.skillInUse.Add(skill.GetComponent<SkillSystem>().GetSkill());
            }
            else{
                print("skill is null!");
            }
        }
        else{
            //스킬 사용중!
            print("skill is use!");
        }
       
    }
}
