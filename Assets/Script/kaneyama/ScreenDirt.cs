﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenDirt : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        var img = GetComponent<Image>();
        img.color = new Color(img.color.r, img.color.g, img.color.b, 1f);
        StartCoroutine(Easing.Tween(0.2f, (t) =>
                {
                    transform.localScale = new Vector3(t, t, 1);
                }, () =>
                {

                    StartCoroutine(Easing.Tween(0.3f, (t) =>
                    {
                        img.color = new Color(img.color.r, img.color.g, img.color.b, 1 - t);
                    }, () => { Destroy(gameObject); }));
                }));
    }
}
