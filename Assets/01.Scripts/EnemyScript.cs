using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public Enemy theEnemy;
    [SerializeField] float hp;
    [SerializeField] GameObject hpPrefab;
    [SerializeField] GameObject hpBar;
    [SerializeField] GameObject dmgText;
    [SerializeField] GameObject dmgSpawner;
    [SerializeField] GameObject logPrefabs;
    GameObject logParents;
    PlayerStatus thePlayer;
    DataBase theDB;

    Vector3 pos;
    Vector3 size;

    GameObject hppre;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerStatus>();
        theDB = FindObjectOfType<DataBase>();
        hppre = Instantiate(hpPrefab,this.transform.position, Quaternion.identity, GameObject.Find("EnemyHP").transform);
        hpBar = hppre;
        dmgSpawner = hppre.transform.GetChild(2).gameObject;

        logParents = GameObject.Find("LogContents");

        hpBar.GetComponent<Slider>().maxValue = theEnemy.Get_enemy_hp();
        hpBar.GetComponent<RectTransform>().localScale = new Vector3(this.gameObject.GetComponent<BoxCollider2D>().size.x * 1.2f,1f,1f);
        hp = theEnemy.Get_enemy_hp();

        GetComponent<SpriteRenderer>().sprite = theEnemy.Get_enemy_Img();

        
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.transform.position;
        size = new Vector3(this.GetComponent<BoxCollider2D>().bounds.size.x, this.GetComponent<BoxCollider2D>().bounds.size.y, 0);
        hpBar.transform.position = pos + new Vector3(0f, size.y / 2,0f);
        dmgText.transform.position = hpBar.transform.position + new Vector3(0f, 0.1f,0f);
        hpBar.GetComponent<Slider>().value = hp;

        if(hp < 0){
            //몬스터가 처치된다면 아이템 드랍 및 경험치, 골드를 획득하게 해야함.
            theDB.spawnEnemyList.RemoveAt(0);
            thePlayer.playerCoin += theEnemy.Get_enemy_coin();
            thePlayer.playerExp += theEnemy.Get_enemy_exp();
            var log = Instantiate(logPrefabs,logParents.transform.position, Quaternion.identity, logParents.transform);
            log.GetComponent<LogSystem>().logImg.sprite = log.GetComponent<LogSystem>().logIcon[0];
            log.GetComponent<LogSystem>().logText.text = theEnemy.Get_enemy_name() + "을(를) 처치하였습니다! \n";
            
            Destroy(hppre);
            Destroy(this.gameObject);
            
        }


    }

    void DropItem(DropItem _item){

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Attack"){
            hp -= thePlayer.finalDmg;
            var dmg = Instantiate(dmgText,dmgSpawner.transform.position, Quaternion.identity,dmgSpawner.transform);
            dmg.GetComponent<Text>().text = "-" + thePlayer.finalDmg.ToString();
            StartCoroutine(dmg.GetComponent<DmgText>().DmgColorCoroutine());
            StartCoroutine(dmg.GetComponent<DmgText>().DmgPosCoroutine());
            StartCoroutine(dmg.GetComponent<DmgText>().DestroyCoroutine());
            Destroy(other.gameObject);
            
        }
    }
}
