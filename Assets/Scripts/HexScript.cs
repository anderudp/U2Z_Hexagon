using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexScript : MonoBehaviour
{
    public static float shrinkSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Vector3.forward * Random.Range(0, 360));
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if (transform.localScale.x < 0.05f) Destroy(gameObject);
    }
}
