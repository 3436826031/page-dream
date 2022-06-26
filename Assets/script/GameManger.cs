using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class GameManger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        StartGame();

    }

    // Update is called once per frame



    public GameObject player;


    public static GameManger instance;
    public void Over()
    {




    }
    string str1 = "hi,你好";
    string str2 = "欢迎来到，xxx的世界，正如你所见，又是那老一套的，救公主，话说回来，咱就不能整点有趣的吗";
    string str3 = "不过你放心，我可是超英（摆）勇（烂）的";
    string str4 = "该说的我都说完了，你知道该这么做的";
    string str5 = "现在！！开始你的游戏，把这该死的聊天框丢一边去吧！";


    public Text showtext;

    public GameObject ltk;

    public bool isOverjc;
    public GameObject HpUI;




    public void StartGame()
    {

        showtext.text = "";
        showtext.DOText(str1, 0.1f).OnComplete(delegate
        {
            showtext.text = "";
            showtext.DOText(str2, 2.5f).OnComplete(delegate
            {

                showtext.text = "";
                showtext.DOText(str3, 2.5f).OnComplete(delegate
                 {
                     showtext.text = "";
                     showtext.DOText(str4, 2.5f).OnComplete(delegate
                     {
                         showtext.text = "";
                         showtext.DOText(str5, 2.5f).OnComplete(delegate {
                             isOverjc = true;


                         });


                     });


                 });

            });
        });





    }



    public Camera theCamera;

    public bool isDrag;
    private Vector3 mousePos;
    private Vector3 oriScreenPos;

    public float spped = 1f;

    void Update()
    {

        if (isOverjc) {


            if (Input.GetMouseButtonDown(0))
            {

                //记录下当前鼠标位置
                mousePos = Input.mousePosition;

                //记录下拖拽物的原始屏幕空间位置
                oriScreenPos = theCamera.WorldToScreenPoint(ltk.transform.position);
                oriScreenPos.z = 5f;
            }



            if (Input.GetMouseButton(0))
            {
                //如果拖拽状态处于true，且有拖拽物



                //获取屏幕空间鼠标增量，并加上拖拽物原始位置（屏幕空间计算）
                Vector3 newPos = oriScreenPos + Input.mousePosition - mousePos;
                //将屏幕空间坐标转换为世界空间
                Vector3 newWorldPos;
                newWorldPos = theCamera.ScreenToWorldPoint(newPos);
                //  newWorldPos.y = xianzhiY;
                //将世界空间位置赋予拖拽物

                ltk.GetComponent<Rigidbody2D>().AddForce(newWorldPos * 10);


            }





        }









    }


    //受伤
    void redure(){
        



        
        }


}
