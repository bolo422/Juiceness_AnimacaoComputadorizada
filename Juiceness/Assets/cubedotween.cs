using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubedotween : MonoBehaviour { 


    void Start()
    {
        StartCoroutine(anim(2.0f));
    }

    void Update()
    {
        
    }

    IEnumerator anim(float restartTime)
    {
        yield return new WaitForSeconds(restartTime);
        //transform.DOShakeScale(1.5f, 2.0f, 1, 00.0f, true);
        //transform.DOBlendableScaleBy(new Vector3(0,-0.62877f, 0), 1.0f).onComplete(() => {
        //    transform.DOBlendableScaleBy(new Vector3(0, 0.62877f, 0), 1.0f);
        //});
        //StartCoroutine(anim(4.0f));
    }
}
