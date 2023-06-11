using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    Enemy theEnemy;
    [SerializeField] float hp;

    [SerializeField] GameObject hpBar;
    [SerializeField] GameObject dmgText;
    [SerializeField] GameObject dmgSpawner;
    PlayerStatus thePlayer;
    DataBase theDB;

    Vector3 pos;
    Vector3 size;

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
        //hpBar.transform.position = Camera.main.WorldToScreenPoint(this.transform.position + new Vector3(0, 0.8f, 0));
        pos = this.transform.position;
        size = new Vector3(this.GetComponent<BoxCollider2D>().bounds.size.x, this.GetComponent<BoxCollider2D>().bounds.size.y, 0);
        hpBar.transform.position = pos + new Vector3(0f, size.y / 2,0f);
        hpBar.GetComponent<Slider>().value = hp;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Attack"){
            hp -= thePlayer.finalDmg;
            var dmg = Instantiate(dmgText,dmgSpawner.transform.position, Quaternion.identity,dmgSpawner.transform);
            dmg.GetComponent<Text>().text = "-" + thePlayer.finalDmg.ToString();
            StartCoroutine(dmg.GetComponent<DmgText>().DmgColorCoroutine());
            StartCoroutine(dmg.GetComponent<DmgText>().DmgPosCoroutine());
            Destroy(other.gameObject);
            
        }
    }
}
