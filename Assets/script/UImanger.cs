using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanger : MonoBehaviour
{
    // Start is called before the first frame update


    public Camera theCamera;

    public bool isDrag;
    private Vector3 mousePos;
    private Vector3 oriScreenPos;

    public float spped = 1f;


    public GameObject shou;
   

    private float xianzhiY;

    void Start()
    {

        isDrag = true;
        theCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }


    // Update is called once per frame
    void Update()
    {



        if (!GameManger.instance.isOverjc) {
            return;
        }


        if (Input.GetMouseButtonDown(0))
        {
            shou.SetActive(true);
                         //记录下当前鼠标位置
                         mousePos = Input.mousePosition;
          
  //记录下拖拽物的原始屏幕空间位置
                  oriScreenPos = theCamera.WorldToScreenPoint(gameObject.transform.position);
            oriScreenPos.z = 5f;
        }



        if (Input.GetMouseButton(0))
        {
            //如果拖拽状态处于true，且有拖拽物


   
                //获取屏幕空间鼠标增量，并加上拖拽物原始位置（屏幕空间计算）
                Vector3 newPos = oriScreenPos + Input.mousePosition - mousePos;
            //将屏幕空间坐标转换为世界空间
            Vector3 newWorldPos;

            if (isDrag)
            {
                 newWorldPos = theCamera.ScreenToWorldPoint(newPos);
              //  newWorldPos.y = xianzhiY;
                //将世界空间位置赋予拖拽物
            }
            else {
                 newWorldPos = theCamera.ScreenToWorldPoint(newPos);

            }
            gameObject.transform.position = newWorldPos * spped;

        }



        if (Input.GetMouseButtonUp(0)) {
            shou.SetActive(false);
        
        }

  








     


    }









    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ("drag".Equals(collision.tag)) {
            isDrag = false;
            //xianzhiY = gameObject.transform.position.y;
       
        }




    }


    private void OnTriggerExit2D(Collider2D collision)
    {

        if ("drag".Equals(collision.tag))
        {
            isDrag = true;

        }



    }

}
