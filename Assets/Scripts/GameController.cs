using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var bottom = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0)).y;
        if (ball.transform.position.y < -bottom)
        {
            // End of the game
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
