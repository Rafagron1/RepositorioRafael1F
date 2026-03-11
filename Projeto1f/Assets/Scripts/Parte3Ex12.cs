using UnityEngine;

public class Parte3Ex12 : MonoBehaviour
{
    int pontosIniciais = 10;
    int inimigosDerrotados = 41;
    int bonus = 90;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ex12()
    {
        int pontosFinais = (pontosIniciais * inimigosDerrotados) + bonus;
        print("Exercício 12\n" + "A pontuação final é: " + pontosFinais);
    }
}
