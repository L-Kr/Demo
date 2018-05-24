using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    private float StartTime;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
            other.GetComponent<Animator>().SetBool("Dying", true);
        if (tag == "Attack1" && (other.tag != "Attack1" && other.tag != "Player"))
            Destroy(gameObject);
    }

    void Start()
    {
        if (tag == "Attack1")
            StartCoroutine(Wait());
        StartTime = Time.time;
    }

    void Update()
    {
        if (tag == "Attack1" && Time.time - StartTime > 5.0f)
            Destroy(gameObject);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        GetComponent<Rigidbody>().velocity = 20.0f * transform.forward;
    }
}
