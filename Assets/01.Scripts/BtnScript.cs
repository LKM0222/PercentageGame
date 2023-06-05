using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnScript : MonoBehaviour
{
    //UI
    [SerializeField] GameObject logScrollview;
    [SerializeField] GameObject statScrollview;

    //Equipment
    [SerializeField] Text statInfo;

    public void OnStatBtnClick(){
        logScrollview.SetActive(false);
        statScrollview.SetActive(true);
    }

    public void OnLogBtnClick(){
        logScrollview.SetActive(true);
        statScrollview.SetActive(false);
    }

    public void OnEquipSlotBtnClick(){
        int code = this.transform.parent.GetComponent<SlotInfo>().equipSlotCode;
    
        statInfo.text = code.ToString() + "설명 들어갈곳!";
    }
}
