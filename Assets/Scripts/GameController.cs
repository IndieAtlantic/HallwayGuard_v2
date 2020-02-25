using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int health;
    public int gamestate;
    public int disrupter;

    public Text healthtext;
    public Text emptext;

    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        disrupter = 1;

        healthtext.text = "";
        emptext.text = "";
    }


    void Awake()
    {
        Application.targetFrameRate = 60;
    }


    // Update is called once per frame
    void Update()
    {
        healthtext.text = "Health: " + health;
        emptext.text = "Disrupters: " + disrupter;

        if (health == 0)
        {
            SceneManager.LoadScene("FailScreen");
        }
    }
}
