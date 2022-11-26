using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class knife : MonoBehaviour {
    public Rigidbody2D rb;
    public float speed = 100f;
    private bool fire;

	// Use this for initialization
	void Start () {
        fire = false;
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) && fire==false)
        {
            hit();
        }
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "FixedKnife")
        {
            Debug.Log("End Game");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    void hit()
    {
        fire = true;
        rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
    }
}
