using UnityEngine;

public class Parte2Ex8 : MonoBehaviour
{
    public int vida = 100;
    public int dano;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ex8()
    {
        vida -= dano;
        print("Exercício 8\n" + "vida= " + vida);
    }
}
