using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pro_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnCollisionEnter(Collision collision)//���ӹ���Ч��
    {
        if (collision.gameObject.tag == "Enemy")
        {
            print("����");
            collision.gameObject.GetComponent<Enemy_>().sh(2);
        }

        print(collision.gameObject.name);
    }
}
