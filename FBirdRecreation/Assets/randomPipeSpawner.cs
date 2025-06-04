using UnityEngine;

public class randomPipeSpawner : MonoBehaviour {

    private float timer = 0;
    public float spawnRate = 3.0f;
    public GameObject pipeToSpawn; //Simplificando para testes caso demore muito para novas intanciações
    public float heightOffset = 2;
    public void spawnPipe() {

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipeToSpawn, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); //gera novos tubos que nascem em alturas distintas.
    }
    void Start() {
        spawnPipe();
    }

    void Update() {
        if(timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }
    }
}
