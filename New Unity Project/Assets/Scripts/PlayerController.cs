using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;

    bool clicked;
    bool started;
    BallController ballController;

    private void Start()
    {
        ballController = transform.GetChild(0).GetComponent<BallController>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        horizontal *= Time.deltaTime; //Move 10 meters per second not 10 meters per frame
        transform.Translate(horizontal, 0, 0);



        if (Input.GetKeyDown("space") && !clicked)
        {
            clicked = true;
            Transform temporaryPostision = transform.GetChild(0).GetComponent<Transform>();
            Vector3 pos = temporaryPostision.TransformPoint(temporaryPostision.position);


            transform.GetChild(0).SetParent(null, true);
            started = true;
        }

        if (started)
        {
            ballController.StartMoving();
        }
    }

}
