using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instans : MonoBehaviour {

    public GameObject knifeprefab;
    public int num=1;
    public int totalknifes = 20;
	// Use this for initialization
	void Start () {
        instanse();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0) && num<20)
        {
            num++;
            instanse();
        }
	}
    void instanse()
    {
        Instantiate(knifeprefab, transform.position, transform.rotation);
    }
}
