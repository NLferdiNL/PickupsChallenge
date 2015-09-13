using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private float m_score = 0;

    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
        this.transform.position += Vector3.right * Time.deltaTime;
    }
}
