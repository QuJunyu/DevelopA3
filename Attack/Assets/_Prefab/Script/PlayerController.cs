using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public static PlayerController playin;  
    private Animator ani; 
    public Transform pos;  // 用于存储生成物体的位置信息

    public GameObject prefab;  // 生成的游戏物体的预制体
    public int hp = 100;  // 玩家的生命值

    public Image hpui;  
    public GameObject overui;  // 游戏结束时显示的UI界面

    private void Awake()
    {
        playin = this;  
    }

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();  // 获取角色的动画组件
    }

    // Update is called once per frame
    void Update()
    {
        // 检测按键输入，如果按下键盘上的 F 键，则攻击状态为 true
        if (Input.GetKeyDown(KeyCode.F))
        {
            ani.SetBool("Attack", true);
        }
    }

    // 生成物体的方法
    public void SC()
    {
        Instantiate(prefab, pos.position, pos.rotation);
    }
    public void attfa()
    {
        ani.SetBool("Attack", false);  // 设置攻击状态为 false
    }

    // 受伤的方法
    public void wounded(int i)
    {
        hp -= i;  // 减去受到的伤害值
        hpui.fillAmount = (float)hp / 100;  
        if (hp <= 0)
        {
            Cursor.lockState = CursorLockMode.None;  // 当生命值小于等于 0 时，解锁鼠标
            ani.SetTrigger("Die");           
        }
    }


    public void diee()
    {
        overui.SetActive(true);  // 激活游戏结束的UI界面
    }
}
