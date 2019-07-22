using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    bool canMove;
    
    [SerializeField] float VelocityX;
    [SerializeField] float VelocityY;
    bool started;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float degree = Vector2.Angle(transform.right, transform.up);
        print(degree);
        
        Debug.DrawRay(transform.position, transform.up, Color.blue);

        if (canMove)
        {
            transform.Translate(new Vector3(VelocityX, VelocityY, 0));




            //transform.Translate(new Vector3(0, .2f, 0), Space.Self);

            ////Calculate distance between origin point (tranfosrm.point) and nerest box collider using raycast
            ////Shoot 2 raycast of one x sencond of -x
            ////RaycastHit2D ray1 =  Physics2D.Raycast(transform.position, new Vector2(transform.position.x,transform.position.y));
            ////RaycastHit2D ray2 = Physics2D.Raycast(transform.position, new Vector2(-1 * Mathf.Abs(transform.position.x), transform.position.y));

            //RaycastHit2D[] hit1 = Physics2D.RaycastAll(transform.position, transform.right, 100f);
            //RaycastHit2D[] hit2 =  Physics2D.RaycastAll(transform.position, -1 * transform.right, 100f);

            //foreach (RaycastHit2D item in hit1)
            //{
            //    if (item.collider.gameObject.tag == "Block")
            //    {
            //        print(item.transform.gameObject.name);
            //        xPlus = Vector3.Distance(transform.position, item.point);
            //        print("xPlus is " + xPlus);
            //    }
            //}

            //foreach (RaycastHit2D item1 in hit2)
            //{
            //    if (item1.collider.gameObject.tag == "Block")
            //    {
            //        print(item1.transform.gameObject.name);
            //        xMinus = Vector3.Distance(transform.position, item1.point);
            //        print("xMinus is " + xMinus);
            //    }
            //}

            //if (xPlus > xMinus)
            //{
            //    rightSide = true;
            //}
            //else
            //    rightSide = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        if (collision.transform.tag == "AxisY")
        {
            VelocityY = -1 * VelocityY;
        }

        else if (collision.transform.tag == "AxisMinusY")
        {
            VelocityY = -1 * VelocityY;
        }
        else if (collision.transform.tag == "AxisX")
        {
            VelocityX = -1 * VelocityX;

        }
        else if (collision.transform.tag == "AxisMinusX")
        {
            VelocityX = -1 * VelocityX;
        }
    }

    public void StartMoving()
    {
        canMove = true;
        started = true;
    }
}
