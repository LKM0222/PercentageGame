using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnBecameInvisible() {
        Destroy(this.gameObject);
    }

    
}
