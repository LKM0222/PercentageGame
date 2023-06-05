using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpawner : MonoBehaviour
{
    [SerializeField] GameObject attackPrefabs;
    float attackTime; //초당 공격
    float t;

    DataBase theDB;
    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<DataBase>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        attackTime = theDB.atkSpd;
        if(attackTime < t){
            Instantiate(attackPrefabs,this.transform.position, Quaternion.identity,this.transform);
            t = 0f;
        }
    }
}
