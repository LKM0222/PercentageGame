using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogPos : MonoBehaviour
{
    [SerializeField] GameObject player;

    Vector3 pos;
    Vector2 size;
    private void Update()
    {
        //pos = this.transform.position;
        size = new Vector3(player.GetComponent<BoxCollider2D>().bounds.size.x, player.GetComponent<BoxCollider2D>().bounds.size.y);
        this.transform.position = player.transform.position + new Vector3(0f, size.y / 2,0f);
    }
}
