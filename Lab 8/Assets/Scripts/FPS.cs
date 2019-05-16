using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    public Light luz;
    // Start is called before the first frame update
    void Start()
    {
        luz.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        luz.intensity = luz.intensity + 0.5f * Mathf.Sin(Time.time);
    }
    private void OnTriggerExit(Collider other)
    {
        luz.intensity = 0;
    }
}
