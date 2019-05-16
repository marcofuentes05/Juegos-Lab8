using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayScript : MonoBehaviour
{
    public Light luz;
    public AudioSource clip;
    bool isOn = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Ray myRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hitInfo;
        transform.Find("Canvas").gameObject.SetActive(false);
        if (Physics.Raycast(myRay, out hitInfo, 5))
        {
            if (!hitInfo.collider.CompareTag("nada"))
            {
                transform.Find("Canvas").gameObject.SetActive(true);
                transform.Find("Canvas").transform.Find("Text").gameObject.GetComponent<Text>().text = hitInfo.collider.tag;
            }
            else
            {
                transform.Find("Canvas").gameObject.SetActive(false);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            clip.Play();
            if (isOn)
            {
                isOn = false;
                luz.intensity = 0;
            }
            else
            {
                isOn = true;
                luz.intensity = 3;
            }
        }

    }
}
