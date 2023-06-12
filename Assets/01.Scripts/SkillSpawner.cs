using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkillSpawner : MonoBehaviour
{
    DataBase theDB;

    [SerializeField] GameObject skillBtn;
    [SerializeField] GameObject skillSpawner;

    private void Awake() {
        theDB = FindObjectOfType<DataBase>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //장착되어있는 스킬만 일단 이렇게 불러옴(이건 게임 시작 및 초기화때 불러오는 코드임)
        for(int i=0;i < theDB.equipedSkill.Count;i++){
            var skill = Instantiate(skillBtn, this.transform.position, Quaternion.identity, skillSpawner.transform);
            skill.GetComponent<Image>().sprite = 
            theDB.skillList.Find(x => x.Get_Skill_Code() == theDB.skillList[i].Get_Skill_Code()).Get_Skill_Img();
            skill.GetComponent<SkillBtn>().skillCode =  
            theDB.skillList.Find(x => x.Get_Skill_Code() == theDB.skillList[i].Get_Skill_Code()).Get_Skill_Code();
            skill.GetComponent<SkillBtn>().skillIcon.GetComponent<SkillSystem>().SetSkill(
                theDB.skillList.Find(x => x.Get_Skill_Code() == theDB.skillList[i].Get_Skill_Code())
            );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
