using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpawner : MonoBehaviour
{
    [SerializeField] GameObject attackPrefabs;
    float attackTime; //초당 공격
    float t;

    PlayerStatus thePlayer;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        attackTime = thePlayer.atkSpd;
        if(attackTime < t){
            Instantiate(attackPrefabs,this.transform.position, Quaternion.identity,this.transform);
            t = 0f;
        }
    }
}
