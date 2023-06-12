using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerLog : MonoBehaviour
{

    //log 순서 : 0:skill error
    public string[] logs = new string[0];

    /// <summary>
    /// _logNum 0: skill을 이미 사용중
    /// </summary>
    public void CoroutineStart(int _lognum){
        StartCoroutine(PlayerLogColorCoroutine());
        StartCoroutine(PlayerLogPosCoroutine(logs[_lognum]));
        StartCoroutine(DestroyCoroutine());
    }
    public IEnumerator PlayerLogColorCoroutine(){
        Color textColor = this.GetComponent<Text>().color;
        float alpha = 1f;
        for (float i =1;i > 0f;i -= 0.01f ){
            alpha -= i;
            this.GetComponent<Text>().color = new Color(textColor.r, textColor.g, textColor.b, i);
            yield return new WaitForSeconds(0.01f);
        } 
        Destroy(this.gameObject);
    }
    public IEnumerator PlayerLogPosCoroutine(string _playerLog){
        Vector3 textPos = this.GetComponent<RectTransform>().localPosition;
        this.GetComponent<Text>().text = _playerLog;
        float yPos = 0f;
        for (float i = 0;i < 3f;i += 0.01f ){
            yPos += i;
            this.GetComponent<RectTransform>().localPosition = new Vector3(textPos.x, yPos,textPos.z);
            yield return new WaitForSeconds(0.01f);
        } 
    }
    public IEnumerator DestroyCoroutine(){
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }


}
