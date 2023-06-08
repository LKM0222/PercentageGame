using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] float hp;

    PlayerStatus thePlayer;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Attack"){
            hp -= thePlayer.Atk;
            //enemy의 체력바를 구현해야됨...
            Destroy(other.gameObject);
        }
    }
}
