using UnityEngine;

public class Cubo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.transform.CompareTag("Esfera"))
        {


            FindAnyObjectByType<GameManager>().SumarPuntos();
            Destroy(gameObject);

        }

    }
}
