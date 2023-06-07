using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public GameObject invenContents;
    public GameObject slotPrefabs;
    DataBase theDB;
    public int i = 0; //아이템 삭제 시 i를 0으로 초기화한 후 다시 정리를 해야될듯...
    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<DataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        for(;i<theDB.inventoryList.Count;i++){
            var inven = Instantiate(slotPrefabs, invenContents.transform.position, Quaternion.identity, invenContents.transform);
            inven.GetComponent<InvenSlot>().itemCode = theDB.inventoryList[i];
        }    
    }
}
