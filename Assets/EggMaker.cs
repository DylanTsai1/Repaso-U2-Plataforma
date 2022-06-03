using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggMaker : MonoBehaviour
{
    public GameObject eggPreFab;
    public GameObject eggSpawnPoint; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon; 
            clon = Instantiate(eggPreFab);
            clon.transform.position = eggSpawnPoint.transform.position; 
        }
    }
}
