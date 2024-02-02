using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    [SerializeField] List<Transform> _itensMenu;

    // Start is called before the first frame update
    

    private IEnumerator TimeItens()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0; i < _itensMenu.Count; i++)
        {
            _itensMenu[i].DOScale(1.2f, .25f); //aumenta volume
            yield return new WaitForSeconds(.25f);
            _itensMenu[i].DOScale(1f, .25f); //diminue o volume de novo
        }
    }

    public void ChamarMenu() 
    {
        //_itensMenu[0].GetComponent<Button>().Select();
        StartCoroutine(TimeItens());
    }

    public void ItensOff()
    {
        for (int i = 0; i < _itensMenu.Count; i++)
        {
            _itensMenu[i].transform.localScale = Vector3.zero;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
