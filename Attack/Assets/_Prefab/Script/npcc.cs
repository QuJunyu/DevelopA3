using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcc : MonoBehaviour
{
    public GameObject KeyInfo;
    public GameObject TalkPlane;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (KeyInfo.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            TalkPlane.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        KeyInfo.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        KeyInfo.SetActive(false);
        TalkPlane.SetActive(false);
    }
}
