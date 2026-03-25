using UnityEngine;

public class Parte3Ex11 : MonoBehaviour
{
    float velocidadeInicial = 10f;
    float aceleracao = 2;
    float tempoDeAceleracao = 10;
    float velocidadeFinal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ex11()
    {
        velocidadeFinal = velocidadeInicial + tempoDeAceleracao * aceleracao;
        print("Exercício 11\n" + "Com velocidade inicial de " + velocidadeInicial +
            " metros por segundo, e uma aceleração de " + aceleracao + " ao final de " +
            tempoDeAceleracao + " segundos o objeto tem velocidade de " + velocidadeFinal);
    }
}
