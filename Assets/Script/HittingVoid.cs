using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingVoid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "egg")
        {
            Destroy(target.gameObject);
        }
        if (target.tag == "goldenEgg")
        {
            Destroy(target.gameObject);
        }
    }
}
