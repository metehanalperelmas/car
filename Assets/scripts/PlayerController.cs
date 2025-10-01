using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject restartButton;
    public float speed = 0.5f;
    Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -1.8f, 1.8f);
        transform.position = position;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Time.timeScale = 0;
        restartButton.SetActive(true);
    }
}
