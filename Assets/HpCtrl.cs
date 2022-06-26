using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class HpCtrl : MonoBehaviour
{
    
    public Image HpImg;
    public int MaxHp = 5;
    public int HpNum;
    public bool CanDoDange= true;
    public static HpCtrl Instance { get; private set; }

    private float Renum;

    public GameObject CardPlayerObj;

    private void Awake()
    {
        Instance = this;

        Renum = HpImg.gameObject.transform.localScale.y / MaxHp;
    }


    public void SetHp(int hp) {
        HpNum = hp;
        CanDoDange = false;
        float tohp = HpNum * Renum;
        HpImg.transform.DOScaleY(tohp, 0.3f);
        StartCoroutine(DoDamage());
    }

    public void ReduceHp() {
        if (!CanDoDange)
            return;
        HpNum -= 1;
        SetHp(HpNum);
        
    }



    public void AddHp() {
        if (!CanDoDange)
            return;
        HpNum += 1;
        SetHp(HpNum);
    }


    IEnumerator DoDamage() {
        for (int i = 0; i < 5; i++)
        {
            CardPlayerObj.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            CardPlayerObj.SetActive(true);
            yield return new WaitForSeconds(0.1f);
        }

        CanDoDange = true;


    }
    



}
