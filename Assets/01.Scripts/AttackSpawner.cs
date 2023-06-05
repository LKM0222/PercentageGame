using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpawner : MonoBehaviour
{
    public GameObject attackPrefabs;
    public float attackTime;
    float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if(attackTime < t){
            Instantiate(attackPrefabs,this.transform.position, Quaternion.identity,this.transform);
            t = 0f;
        }
    }
}
