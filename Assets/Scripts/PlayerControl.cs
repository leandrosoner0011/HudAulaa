using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] ControlMenuGame _controlMenuGame;
    [SerializeField] int _quantVida;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Hit")
        {
            _quantVida--;
            _controlMenuGame.CheckIconVida(_quantVida);
        }
    }
}
