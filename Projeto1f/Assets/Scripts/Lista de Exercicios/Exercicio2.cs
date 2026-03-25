using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    int vida = 100;
    int dano = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ex2()
    {
        print("Exercício 2\n" + "Você recebe uma machadada e recebe " + dano + " de dano, ficando com um total de " + (vida - dano) + " de vida");

    }
}
