using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject egg, goldenEgg, bomb;
    public float xBound, ybound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEgg());
    }
    IEnumerator spawnEgg()
    {
        yield return new WaitForSeconds(Random.Range(0,2));
        int randomEgg = Random.Range(0,100);
        if(randomEgg > 50)
            Instantiate(egg, new Vector2(Random.Range(-xBound, xBound), ybound), Quaternion.identity);
        else if(randomEgg < 40)
            Instantiate(bomb, new Vector2(Random.Range(-xBound, xBound), ybound), Quaternion.identity);
        else
            Instantiate(goldenEgg, new Vector2(Random.Range(-xBound, xBound), ybound), Quaternion.identity);

        StartCoroutine(spawnEgg());
    }
}
