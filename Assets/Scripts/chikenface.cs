using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chikenface : MonoBehaviour {

    private float speed;
    public Rigidbody2D rb;
    public WheelJoint2D wj;
    public GameObject Instantiater;
	// Use this for initialization
	void Start ()
    {
        speedchange();
        rb.GetComponents<Rigidbody2D>();
	}

    void Update()
    {
        float totalknifes = Instantiater.GetComponent<Instans>().totalknifes;
        if(transform.childCount > totalknifes)
        {
            Debug.Log ("Game Completed");
        }
    }
	
	void FixedUpdate()
    {
        wj.useMotor = true;
        JointMotor2D motor = new JointMotor2D { motorSpeed = speed, maxMotorTorque=wj.motor.maxMotorTorque};
        wj.motor = motor;
    }

    void speedchange()
    {
        speed = Random.Range(-250, 250);
        StartCoroutine(speedtime());
    }

    IEnumerator speedtime()
    {
        yield return new WaitForSeconds(3f);
        speedchange();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Knife")
        {
            col.gameObject.tag = "FixedKnife";
            Destroy(col.attachedRigidbody);
            col.transform.parent = this.transform;
        }
        
    }
}
