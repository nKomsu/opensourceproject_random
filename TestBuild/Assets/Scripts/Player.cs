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

        //이동
        transform.position += moveVec * speed * Time.deltaTime;

        //애니메이션
        anim.SetBool("isrun", hAxis != 0 || vAxis != 0);

        //방향전환
        transform.LookAt(transform.position + moveVec);
    }
}
