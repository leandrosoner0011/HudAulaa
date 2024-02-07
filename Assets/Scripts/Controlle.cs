using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlle : MonoBehaviour
{
    [SerializeField] GameObject _obj;
    [SerializeField] GameObject[] _pos;
    [SerializeField] float _tamIni; // tamanho inicial

    // Start is called before the first frame update
    private void Start()
    {
        _tamIni = _obj.transform.localScale.x;
       StartCoroutine(TimeMove());
        //_obj.transform.DOLocalJump(_pos[1].transform.position, 20, 4, 2, false);
        //_obj.transform.DOShakeScale(2, 10, 6, 8, false, ShakeRandomnessMode.Full);
        
    }

    IEnumerator TimeMove()
    {
        _obj.transform.DOMove(_pos[1].transform.position, 1);
        _obj.transform.DOLocalJump(_pos[1].transform.position, 20, 4, 2, false);
        _obj.transform.DOShakeScale(2, 10, 6, 8, false, ShakeRandomnessMode.Full);
        yield return new WaitForSeconds(1f);
        _obj.transform.DOScale(_tamIni+100, 0.25f);
        yield return new WaitForSeconds(0.25f);
        _obj.transform.DOScale(_tamIni, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
