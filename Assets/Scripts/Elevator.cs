using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    public Transform subject;
    public Transform end;

    public float speed;

    public bool rise;

    public GameObject gc;

    // Start is called before the first frame update
    void Start()
    {
        rise = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (rise)
        {
            float step = speed * Time.deltaTime;
            subject.position = Vector3.MoveTowards(subject.position, end.position, step);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            rise = true;
            gc.GetComponent<GameController>().wintext.text = "You Win";
        }
    }
}