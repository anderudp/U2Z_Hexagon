using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject HexPrefab;
    public static float spawnCooldown = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnHexes());
    }

    IEnumerator spawnHexes()
    {
        while(true)
        {
            Instantiate(HexPrefab);
            yield return new WaitForSeconds(spawnCooldown);
        }
    }
}
