using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigid;
    public float touchPower = .1f;

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePosInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            rigid.AddForce((mousePosInWorld - (Vector2)transform.position)* touchPower, ForceMode2D.Impulse);
        }
    }

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
}
