using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public GameObject huoyan;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if ( Input.GetKeyDown(KeyCode.W)) {
           // GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200f));


            //获取喷射点的位置角度，直接发射

            Quaternion rotation = transform.rotation;
            Vector3 localEulerAngles = transform.localEulerAngles;
            print("此物体旋转的角度为："+localEulerAngles.ToString());
           
            print("此物体旋转的角度2为：" + transform.localRotation);
            Vector2 vector2 = new Vector2(rotation.x*200f, rotation.y*200f);

            Vector2 vector21 = new Vector2(-1, Mathf.Sin(localEulerAngles.z-90f))*100f;
            print("此物体旋转的角度2为：" + vector21);
            Vector3 forward = transform.forward;

            print("此物体旋转的角度333为：" + vector21);

            //获取喷射器的位置角度
            GetComponent<Rigidbody2D>().AddForce(forward);

            huoyan.SetActive(true);



        }


        if (Input.GetKeyUp(KeyCode.W))
        {
            // GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200f));
            huoyan.SetActive(false);

       



        }





        if (Input.GetKey(KeyCode.A))
        {
            //GetComponent<Rigidbody2D>().AddForce(new Vector2(-200f, 0));
            //  transform.Rotate(Vector2.right * Time.deltaTime * 200);

            transform.Rotate(new Vector3(0, 0, -1f) * Time.deltaTime * 200);
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(200f, 0));

        }


        if (Input.GetKey(KeyCode.D))
        {
           // GetComponent<Rigidbody2D>().AddForce(new Vector2(200f, 0));
            transform.Rotate(new Vector3(0,0,1f) * Time.deltaTime * 200);
        }

    }







}
