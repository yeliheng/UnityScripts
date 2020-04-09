using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 2020-04-09
 * UI淡入淡出(需要组件:CanvasGroup)
 * Written By Yeliheng
 */

public class UIFadeInFadeOut : MonoBehaviour
{
    public float speed = 2f;//淡入淡出速率
    private float UIAlpha = 1;//初始化时让UI显示
    private CanvasGroup canvasGroup;

    // Use this for initialization
    void Start()
    {
        canvasGroup = this.GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canvasGroup == null)
            return;       

        if (UIAlpha != canvasGroup.alpha)
        {
            canvasGroup.alpha = Mathf.Lerp(canvasGroup.alpha, UIAlpha, speed * Time.deltaTime);
            if (Mathf.Abs(UIAlpha - canvasGroup.alpha) <= 0.01f)
            {
                canvasGroup.alpha = UIAlpha;
            }
        }
    }
    public void UIFadeInEvent()
    {
        UIAlpha = 1;
        canvasGroup.blocksRaycasts = true;      //可以和该对象交互
    }
    public void UIFadeOutEvent()
    {
        UIAlpha = 0;
        canvasGroup.blocksRaycasts = false;     //不可以和该对象交互
    }
}
