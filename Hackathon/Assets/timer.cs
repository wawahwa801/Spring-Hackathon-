using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float time = 0;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }
}
