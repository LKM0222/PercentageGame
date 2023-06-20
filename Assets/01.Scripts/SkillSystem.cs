using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//스킬을 사용 했을때 타이머 기능 및 사용중 스킬 슬롯에 추가하는 기능

public class SkillSystem : MonoBehaviour
{
    [SerializeField] Slider skillSlider;

    [SerializeField] Text skillTimeText;

    [SerializeField] Skill skill;

    float t = 0f;
    DataBase theDB;


    private void Awake()
    {
        theDB = FindObjectOfType<DataBase>();
    }

    // Start is called before the first frame update
    void Start()
    {
        skillSlider.maxValue = 15f;

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        skillSlider.value = t;
        skillTimeText.text = t.ToString("#.0") + "s";
        if(t > skillSlider.maxValue){ //지속시간이 끝난경우
            theDB.skillInUse.Remove(theDB.skillInUse.Find(x => x.Get_Skill_Code() == skill.Get_Skill_Code()));
            Destroy(this.gameObject);
        }
    }

    public void SetSkill(Skill _skill){
        skill = _skill;
    }

    public Skill GetSkill(){
        return skill;
    }
}
