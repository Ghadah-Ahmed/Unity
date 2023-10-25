using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class Movement : MonoBehaviour
{
    public Rigidbody Rigidbody;
    [SerializeField] Transform groungCheck;
    [SerializeField] LayerMask ground;
    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }


    void Update()
    {
        if (view.IsMine)
        {
            Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * 5f, Rigidbody.velocity.y, Input.GetAxis("Vertical") * 5f);
            //Vector3 direction = new Vector3(Rigidbody.velocity.x, 0, Rigidbody.velocity.z);
            //Rigidbody.MoveRotation(Quaternion.LookRotation(direction));

            if (Input.GetButton("Jump") && isGrounded())
            {
                Rigidbody.velocity = new Vector3(Rigidbody.velocity.x, 7f, Rigidbody.velocity.z);
            }
        }   
    }

    bool isGrounded()
    {
        return Physics.CheckSphere(groungCheck.position, .2f, ground);
    }
}






//if (Input.GetKey(KeyCode.LeftArrow))
//{
//    this.transform.Translate(new Vector3(-10f, 0f, 0f) * Time.deltaTime, Space.Self);
//}
//else if (Input.GetKey(KeyCode.RightArrow))
//{
//    this.transform.Translate(new Vector3(10f, 0f, 0f) * Time.deltaTime, Space.Self);
//}
//else if (Input.GetKey(KeyCode.UpArrow))
//{
//    this.transform.Translate(new Vector3(0f, 0f, 10f) * Time.deltaTime, Space.Self);
//}
//else if (Input.GetKey(KeyCode.DownArrow))
//{
//    this.transform.Translate(new Vector3(0f, 0f, -10f) * Time.deltaTime, Space.Self);
//}
//else if (Input.GetKey(KeyCode.Space))
//{
//    this.transform.Translate(new Vector3(0f, 10f, 0f) * Time.deltaTime, Space.Self);
//}