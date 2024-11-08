using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float pcMoveSpeed = 300f;
    float mobileMoveSpeed = 75f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Application.isMobilePlatform) MobileInput();
        else PcInput();
    }

    void PcInput()
    {
        transform.RotateAround(Vector3.zero, Vector3.back, pcMoveSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }

    void MobileInput()
    {
        foreach(Touch t in Input.touches)
        {
            if(t.phase == TouchPhase.Moved) transform.RotateAround(Vector3.zero, Vector3.back, mobileMoveSpeed * Time.deltaTime * t.deltaPosition.x);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
