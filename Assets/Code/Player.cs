using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float m_score = 0;
    public float speed = 1;
    public bool rotate = false;
    public GameObject camera;

    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
        this.transform.position += (Vector3.right * Time.deltaTime)*speed;
        if (rotate) { this.transform.Rotate(new Vector3(0, 0, speed * 2));  }
        if (camera != null) { camera.transform.position = new Vector3(this.transform.position.x,0.69f,-10); }
    }

    public float addScore(float i)
    {
        m_score += i;
        print("Score updated! It's now: " + m_score);
        return m_score;
    }
}
