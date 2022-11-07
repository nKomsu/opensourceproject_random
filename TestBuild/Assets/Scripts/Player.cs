using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float hAxis;
    float vAxis;
    public float speed = 15;
    bool wDown;

    Vector3 moveVec;

    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        //anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        //�̵�
        transform.position += moveVec * speed * Time.deltaTime;

        //�ִϸ��̼�
        anim.SetBool("isrun", hAxis != 0 || vAxis != 0);

        //������ȯ
        transform.LookAt(transform.position + moveVec);
    }
}