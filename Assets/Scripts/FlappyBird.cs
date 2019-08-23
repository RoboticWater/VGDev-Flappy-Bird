using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    public float jumpForce = 200;
    public PipeSpawner ps;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // ps.spawnTime = 0;
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other) {
        score++;
        print(score);
    }
}
