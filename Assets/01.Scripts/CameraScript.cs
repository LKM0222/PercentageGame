using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] GameObject target;
    Vector3 pos;
    Vector3 pos2;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(this.transform.position.x - target.transform.position.x, this.transform.position.y - target.transform.position.y, this.transform.position.z);
        pos2 = new Vector3(this.transform.position.x + pos.x ,this.transform.position.y +pos.y, pos.z );
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(target.transform.position.x + pos.x, target.transform.position.y + pos.y, this.transform.position.z);
    }
}
