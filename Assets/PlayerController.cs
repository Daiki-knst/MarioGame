using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   //変数を宣言
    float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Z軸方向に進み続ける
        this.transform.position += new Vector3 (0, 0, speed * Time.deltaTime);

        //右矢印キーを押している間
           if(Input.GetKey("right")==true)
        {
            //X軸方向へ動く
            this.transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
        }
        //左矢印キーを押している間
        if(Input.GetKey("left") == true)
        {
            //X軸方向へ動く
            this.transform.position -= new Vector3 (speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("up") == true)
        {
            //ジャンプする
            this.transform.position += new Vector3(0, 4, 0);
        }

    }
    //衝突したときに呼び出される
    void OnCollisionEnter(Collision col)
    {
        //Enemyタグと衝突したとき
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit Enemy");
            this.transform.localScale *= 0.5f; //自分のScaleを0.5倍に
            this.transform.position = new Vector3(0, 0, 0);
        }
        if (col.gameObject.tag == "Goal")
        {
            Debug.Log("Goal!!!");
            this.transform.localScale *= 1.5f;
            this.transform.position = new Vector3(0, 0, 0);
        }
    }
}
