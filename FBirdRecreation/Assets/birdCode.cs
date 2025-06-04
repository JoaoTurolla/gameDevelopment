using Unity.VisualScripting;
using UnityEngine;
public class birdCode : MonoBehaviour {

    private bool isAlive = true;
    private float flyStrength = 10.0f;
    public Rigidbody2D myRB;
    public logicManager logicBird;

    void Start() {
        logicBird = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicManager>();
    }
    private void OnFly() {
        if(isAlive){
            myRB.linearVelocityY = flyStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        logicBird.gameOver();
        isAlive = false;
    }
}
