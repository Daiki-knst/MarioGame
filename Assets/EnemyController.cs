using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (this.transform.position.x > 3)
        {
            speed *= -1;
        }
        if(this.transform.position.x<-3)
        {
            speed *= -1;
        }
        
    }
}
