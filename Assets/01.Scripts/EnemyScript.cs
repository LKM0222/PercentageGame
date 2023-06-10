using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    Enemy theEnemy;
    [SerializeField] float hp;

    [SerializeField] GameObject hpBar;
    PlayerStatus thePlayer;
    DataBase theDB;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerStatus>();
        theDB = FindObjectOfType<DataBase>();

        hpBar.GetComponent<Slider>().maxValue = theDB.enemyList[0].Get_enemy_hp();
        hp = theDB.enemyList[0].Get_enemy_hp();
    }

    // Update is called once per frame
    void Update()
    {
       //hpBar.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 0.8f, 0));
        hpBar.GetComponent<Slider>().value = hp;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Attack"){
            hp -= thePlayer.finalDmg;
            //enemy의 체력바를 구현해야됨...
            Destroy(other.gameObject);
        }
    }
}
