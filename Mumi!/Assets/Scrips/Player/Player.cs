using UnityEngine;

public class Player : MonoBehaviour
{
    
    private float speed = 5f;

    //defino los carriles 
    [SerializeField]
    public enum Side { Left, Mid, Right }

    //selecciono el carril de preferencia
    public Side pSide = Side.Mid;

    //creo una variable para cambiar la posición de x y para su valor
    float newXPosition = 0f;
    public float xValue;

    //creo las variables para ingresar el movimiento izquierda y derecha
    public bool GoLeft;
    public bool GoRight;

    //variables para el salto

    //creo un CharacterController para mover al player 
    private CharacterController playerController;

    //creo un AnimatorController para animar al player
    [SerializeField] Animator playerAnimator;

    /*private float cameraAxisX = 0f;
    public float rotationSensibility = 0.5f;
    public float rotationSpeed = 2f;*/ 
    // Start is called before the first frame update
    void Start()
    {
        //obtengo el componente CharacterController
        playerController = GetComponent<CharacterController>();
        //transform.position = Vector3.zero;
    }

    void Update()
    {
        //defino el movimiento a la izquierda
        GoLeft = Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
        if (GoLeft)
        {
            if (pSide == Side.Mid)
            {
                newXPosition = -xValue;
                pSide = Side.Left;  
            }
            else if (pSide == Side.Right)
            {
                newXPosition = 0;
                pSide = Side.Mid;
            }
        }

        //defino el movimiento a la derecha
        GoRight = Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);
        if (GoRight)
        {
            if (pSide == Side.Mid)
            {
                newXPosition = xValue;
                pSide = Side.Right;
            }
            else if (pSide == Side.Left)
            {
                newXPosition = 0;
                pSide = Side.Mid;
            }
        }
        playerController.Move((newXPosition - transform.position.x) * Vector3.right);
        Move();

        //Defino el salto

        //falta el roll
        
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    /*// Update is called once per frame
    void Update()
    {
        RotatePlayer();
        MoveAxis();
    }
    
    private void MoveAxis()
    {
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(ejeHorizontal, 0, ejeVertical);
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion newRotation = Quaternion.Euler(0, cameraAxisX, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
    }*/
}
