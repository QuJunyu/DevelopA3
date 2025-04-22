using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;



public class Enemy_ : MonoBehaviour
{
    public Transform target; // 玩家角色的Transform
    public float chaseRange = 10f; // 追逐范围
    public float attackRange = 2f; // 攻击范围
    public float attackDelay = 2f; // 攻击间隔

    private float returnToOriginalDistance = 3f;


    public int enemyhp = 3;

    private NavMeshAgent agent;
    private Animator animator;
    private float nextAttackTime = 0f;
    private Vector3 originalPosition;//获取三个敌人的位置


    public int Heatch = 10;
    public Image hpui;//血条显示




    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent <Animator>();

        // 保存敌人的原始位置
        originalPosition = transform.position;
    }

    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        if (distanceToTarget <= chaseRange)
        {
            agent.SetDestination(target.position);

            if (distanceToTarget <= attackRange)
            {
                // 攻击逻辑
                Attack();
            }
            else
            {
                SetIsAttacking(false);
                // 移动动画
                SetIsMoving(true);
            }
        }
        else
        {
            // 不在追逐范围内，停止移动
            agent.ResetPath();

            // 返回原点或者巡逻等逻辑
            ReturnToOriginalPosition();
        }
    }

    void Attack()
    {
        if (Time.time >= nextAttackTime)
        {
            Debug.Log("Attack!");

            // 攻击动画
            SetIsMoving(false);
            SetIsAttacking(true);
            // 获取角色与敌人之间的距离
            float distanceToTarget = Vector3.Distance(transform.position, target.position);

            // 如果角色在攻击范围内
            if (distanceToTarget <= attackRange)
            {
                
            }

            // 设置下一次攻击的时间
            nextAttackTime = Time.time + attackDelay;


        }
    }

    public void attackplayer()
    {
        PlayerController.playin.wounded(10);
    }

    void ReturnToOriginalPosition()
    {
        float distanceToOriginal = Vector3.Distance(transform.position, originalPosition);

        if (distanceToOriginal > returnToOriginalDistance)
        {           
           
            agent.SetDestination(originalPosition);
           
            // 移动动画
            SetIsMoving(true);
        }
        else
        {
            // 不需要移动，停止移动动画
            SetIsMoving(false);
        }

        // 攻击动画
        SetIsAttacking(false);
    }

    void SetIsMoving(bool isMoving)
    {
        // 设置Animator的bool参数
        animator.SetBool("IsMoving", isMoving);
    }

    void SetIsAttacking(bool isAttacking)
    {
        // 设置Animator的bool参数
        animator.SetBool("IsAttacking", isAttacking);
    }

    public void sh(int i)
    {
        Heatch -= i;
        hpui.fillAmount = (float)Heatch / 10;
        if (Heatch <= 0)
        {
            die();
        }
    }

    public void die()
    {
        agent.isStopped = true;
        animator.Play("Die");
        Destroy(gameObject,3f);

    }
}
