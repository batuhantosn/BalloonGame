using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creater : MonoBehaviour
{
    public GameObject Balloon;
    public float createTime = 1f;
    public float timeCounter = 0f;


    GameControl bb;
    void Start()
    {
        bb = this.gameObject.GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter -= Time.deltaTime;

        int fastNumber = (int)(bb.timeCounter / 10)-6;
        fastNumber *= -1;
        if (timeCounter < 0 && bb.timeCounter>0)
        {
            GameObject go = Instantiate(Balloon,new Vector3(Random.Range(-2.75f,2.75f),-6f,0),Quaternion.Euler(0,0,0));
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(30f*fastNumber,80f*fastNumber),0));
            timeCounter = createTime;
        }
        
    }
}
