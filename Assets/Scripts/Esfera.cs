using UnityEngine;
using UnityEngine.InputSystem;

public class Esfera : MonoBehaviour
{
    public Rigidbody rb;

    public Vector2 teclaXY;
    private float movimientoX;
    private float movimientoY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    //buscar un componente q sea tipo Rigidbody y asignarlo a rb

      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMove(InputValue teclasPulsadas){
       teclaXY = teclasPulsadas.Get<Vector2>();
      /*se puede poner esto
        movimientoX = mov.x;
        movimientoY = mov.y;*/

        //esta es la opción mas corta
       Debug.Log(teclaXY.x + " " + teclaXY.y);

    }

    private void FixedUpdate()
    {
        Vector3 movimiento = new Vector3(teclaXY.x, 0, teclaXY.y);
        rb.linearVelocity = movimiento * 5;
    }
}
