using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IncreaseDifficulty());
    }
    
    IEnumerator IncreaseDifficulty()
    {
        while(SpawnController.spawnCooldown > 0.75f)
        {
            yield return new WaitForSeconds(3f);
            HexScript.shrinkSpeed += 0.08f;
            SpawnController.spawnCooldown -= 0.025f;
        }
    }
}
