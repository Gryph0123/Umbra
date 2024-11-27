using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class winCondition : MonoBehaviour
{

    public float timer;
    public TextMeshProUGUI WinOrLose;
    public TextMeshProUGUI timerShow;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        WinOrLose.text = "Get to the goal in under 80 seconds!";
        WinOrLose.fontSize = 18;
    }
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 80f)
        {
            WinOrLose.fontSize = 40;
            WinOrLose.text = "You Lose";
        }
        else if (timer > 5f)
        {
            WinOrLose.text = "";
        }
        timerShow.text = timer.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (timer <= 80f)
        {
            WinOrLose.fontSize = 40;
            WinOrLose.text = "You Win!";
        }
    }
}
