using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float moveSpeed = 5f;  
    private Rigidbody2D _rb;       

    private Vector2 _movement;     

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {        
        GetInput();
        SetDirection();
    }

    void FixedUpdate()
    {        
        _rb.velocity = _movement * moveSpeed * Time.fixedDeltaTime;
    }    

    void GetInput(){
        _movement.x = Input.GetAxis("Horizontal");
        _movement.y = Input.GetAxis("Vertical");
    }

    void SetDirection(){
        if (_movement.x > 0){
            transform.localScale = Vector3.one;
        }
        else if (_movement.x < 0){
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
