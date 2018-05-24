using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2 : MonoBehaviour {

    public ParticleSystem p;
    public GameObject Exprossion;
    private float StartTime;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * 25.0f;
        StartTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time-StartTime > 3.0f)
        {
            Instantiate(Exprossion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
	}
}
