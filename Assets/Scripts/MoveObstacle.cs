using UnityEngine;
using System.Collections;

public class MoveObstacle : MonoBehaviour
{

    private Vector2 moveVelocity = new Vector2(-4, 0);
    

    private void Start()
    {
        StartCoroutine(MyCoroutine());
        GetComponent<Rigidbody2D>().velocity = moveVelocity;
        transform.position = new Vector3(transform.position.x, transform.position.y - 2 * Random.value, transform.position.z);
        transform.Rotate(0, 0, Random.Range(-30f, 30f));
    }

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(5.3f);
        GameObject bird = GameObject.Find("Bird");
        Score score=bird.GetComponent<Score>();
        score.score+=1;
        Destroy(gameObject);
    }
}
