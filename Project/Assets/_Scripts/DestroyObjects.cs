using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
      if (transform.position.x <= -172f) 
        {
            Destroy(gameObject);
        }  
    }
}
