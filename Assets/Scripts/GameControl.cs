using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public UnityEngine.UI.Text timeText, balloonText;
    public GameObject pop;
    public float timeCounter = 60;
    int popCounter = 0;
    void Start()
    {
        balloonText.text = "Ballon : " + popCounter;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeCounter>0)
        {
        timeCounter -= Time.deltaTime;
        timeText.text = "Time = " + (int)timeCounter;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balloon");
            for (int i = 0; i < go.Length; i++)
            {
                GameObject ins = Instantiate(pop, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
                Destroy(ins, 0.3f);
            }
        }
        
    }

    public void BalloonCounter()
    {
        popCounter += 1;
        balloonText.text = "Ballon : " + popCounter;
    }
}
