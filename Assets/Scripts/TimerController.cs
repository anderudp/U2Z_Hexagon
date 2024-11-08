using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    int time = 0;
    public TMP_Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        TimerUpdate();
        StartCoroutine(Tick());
    }

    void TimerUpdate()
    {
        timerText.text = $"Time: {time}";
    }

    IEnumerator Tick()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);
            time++;
            TimerUpdate();
        }
    }
}
