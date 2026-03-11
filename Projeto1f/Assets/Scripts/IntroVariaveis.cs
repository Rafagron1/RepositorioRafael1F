using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class IntroVariaveis : MonoBehaviour
{
    [SerializeField] private string nomeFuncionario;
    [SerializeField] private float tempoTrabalhado;
    [SerializeField] private float valorPorHora;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        print(nomeFuncionario + " trabalha " + tempoTrabalhado + " horas por dia e ganha " + valorPorHora + " reais por hora. No final do dia ele recebeu: " + (tempoTrabalhado * valorPorHora) + " reais.");
         
    }

    // Update is called once per frame
    void Update()
    {
        
            
    }

    public void Fome()
    {
        print("Fome");
    }
    public void Sono()
    {
        print("Sono");
    }
}
