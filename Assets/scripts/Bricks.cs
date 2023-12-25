using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public UIManager ui;
    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "ball") {
            ui.IncrementScore();
            Destroy (gameObject);

        }
    }
}
