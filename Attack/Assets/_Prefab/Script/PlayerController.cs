using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public static PlayerController playin;  
    private Animator ani; 
    public Transform pos;  // ���ڴ洢���������λ����Ϣ

    public GameObject prefab;  // ���ɵ���Ϸ�����Ԥ����
    public int hp = 100;  // ��ҵ�����ֵ

    public Image hpui;  
    public GameObject overui;  // ��Ϸ����ʱ��ʾ��UI����

    private void Awake()
    {
        playin = this;  
    }

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();  // ��ȡ��ɫ�Ķ������
    }

    // Update is called once per frame
    void Update()
    {
        // ��ⰴ�����룬������¼����ϵ� F �����򹥻�״̬Ϊ true
        if (Input.GetKeyDown(KeyCode.F))
        {
            ani.SetBool("Attack", true);
        }
    }

    // ��������ķ���
    public void SC()
    {
        Instantiate(prefab, pos.position, pos.rotation);
    }
    public void attfa()
    {
        ani.SetBool("Attack", false);  // ���ù���״̬Ϊ false
    }

    // ���˵ķ���
    public void wounded(int i)
    {
        hp -= i;  // ��ȥ�ܵ����˺�ֵ
        hpui.fillAmount = (float)hp / 100;  
        if (hp <= 0)
        {
            Cursor.lockState = CursorLockMode.None;  // ������ֵС�ڵ��� 0 ʱ���������
            ani.SetTrigger("Die");           
        }
    }


    public void diee()
    {
        overui.SetActive(true);  // ������Ϸ������UI����
    }
}
