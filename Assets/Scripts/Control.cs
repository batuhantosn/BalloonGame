using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject pop;
    GameControl popScript;

    private void Start()
    {
        popScript = GameObject.Find("_Scripts").GetComponent<GameControl>();
    }
    private void OnMouseDown()
    {
        GameObject go = Instantiate(pop, transform.position , transform.rotation);
        Destroy(this.gameObject);
        Destroy(go,0.3f);
        popScript.BalloonCounter();
    }
}
