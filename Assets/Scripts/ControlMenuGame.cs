using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenuGame : MonoBehaviour
{
    [SerializeField] Transform[] _iconVida;
    [SerializeField] Transform _telaGameOver;

    // Start is called before the first frame update
    void Start()
    {
        //_iconVida[2].DOScale(0, 0.5f); // a vida vai chegar a a zero dentro de 0.5 segundos
    }

    public void CheckIconVida(int Vida)
    {
        if (Vida == 0)
        {
            _iconVida[0].DOScale(0, 0.5f);
            _telaGameOver.DOScale(1, 0.5f);

            //chamar tela GameOver
        }
        else if (Vida == 1)
        {
            _iconVida[1].DOScale(0, 0.5f);
        }
        else if (Vida == 2)
        {
            _iconVida[2].DOScale(0, 0.5f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
