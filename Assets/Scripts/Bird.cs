using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Bird : MonoBehaviour
{

    public SpriteRenderer birdGraphics;
    private Bird bird;

    private void Awake()
    {
        bird = GetComponent<Bird>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300));
        }

        Vector2 position = Camera.main.WorldToScreenPoint(transform.position);

        if(position.y>Screen.height || position.y<0)
        {
            StartCoroutine(MyCoroutine());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        Score score=GetComponent<Score>();
        score.Save();
        birdGraphics.flipY = true;
        bird.enabled = false;
        yield return new WaitForSeconds(1.1f);
        SceneManager.LoadScene("Menu");
    }
}
