using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class scoreTrigger : MonoBehaviour {

    public logicManager logic;

    void Start() {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicManager>();
    }
   
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision) {
        if(collision.gameObject.layer == 3) {
            logic.addScore(1);
        }
    }
}
