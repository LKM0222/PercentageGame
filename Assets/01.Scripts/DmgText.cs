using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DmgText : MonoBehaviour
{ 
    public IEnumerator DmgColorCoroutine(){
        Color textColor = this.GetComponent<Text>().color;
        float alpha = 1f;
        for (float i =1;i > 0f;i -= 0.01f ){
            alpha -= i;
            this.GetComponent<Text>().color = new Color(textColor.r, textColor.g, textColor.b, i);
            yield return new WaitForSeconds(0.01f);
        } 
        Destroy(this.gameObject);
    }
    public IEnumerator DmgPosCoroutine(){
        Vector3 textPos = this.GetComponent<RectTransform>().localPosition;
        float yPos = 0f;
        for (float i = 0;i < 3f;i += 0.01f ){
            yPos += i;
            this.GetComponent<RectTransform>().localPosition = new Vector3(textPos.x, yPos,textPos.z);
            yield return new WaitForSeconds(0.01f);
        } 
    }

}
