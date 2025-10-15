using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public TMP_Text textoPuntos;
    private int puntos;
    private int totalCubos;

    void Start()
    {
        puntos = 0;
        textoPuntos.text = puntos.ToString();
        totalCubos = transform.childCount;

    }

    private void Update()
    {
        if(puntos >= totalCubos)
        {
            //UnityEngine.SceneManagement.SceneManager.LoadScene("Nivel 2");

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

    public void SumarPuntos()
    {
        puntos++;
        textoPuntos.text = puntos.ToString();
    }
}
