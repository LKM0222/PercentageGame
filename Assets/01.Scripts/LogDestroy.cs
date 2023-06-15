using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogDestroy : MonoBehaviour
{
    public void LogDestory(){
        Destroy(this.gameObject.transform.GetChild(0));
    }
}
