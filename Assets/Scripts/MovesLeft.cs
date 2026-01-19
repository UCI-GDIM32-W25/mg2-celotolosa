using UnityEngine;

public class MovesLeft : MonoBehaviour
{
    private GameController _gameController;
    private float _moveSpeed = 3f;
    void Start()
    {
        _gameController = FindObjectOfType<GameController>();
    }
    
    void Update()
    {
       
        transform.Translate(Vector2.left * _moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
            _gameController.UpdatePoints();
        }
        else if (other.gameObject.tag.Equals("Destroyer"))
        {
            Destroy(gameObject);
        }
    }

   
}
