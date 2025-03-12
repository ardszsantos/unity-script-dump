using UnityEngine;
using UnityEngine.UI;

public class gameSystem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InputField input_1;
    public InputField input_2;
    public InputField input_3;

    public Text pc_number;

    public Text resultado;

    bool par;
    string vencedor;



    public void Jogar()
    {
        SortearPC();

        string jogador_1 = input_1.text;
        int num_player1 = int.Parse(input_2.text);

        int soma = int.Parse(pc_number.text) + num_player1;
        string input3Conteudo = input_3.text;

        if (soma % 2 == 0)
        {
            par = true;
        } else
        {
            par = false;
        }


        if (par == true && input3Conteudo == "par")
        {
            vencedor = jogador_1;
            resultado.text = soma.ToString() + " é par! portanto, o vencedor é: " + vencedor;
        }
        else if (par == false && input3Conteudo == "impar")
        {
            vencedor = jogador_1;
            resultado.text = soma.ToString() + " é impar! portanto, o vencedor é: " + vencedor;
        }
        else if (par == true && input3Conteudo == "impar")
        {
            vencedor = "PC";
            resultado.text = soma.ToString() + " é par! portanto, o vencedor é: " + vencedor;
        }
        else if (par == false && input3Conteudo == "par")
        {
            vencedor = "PC";
            resultado.text = soma.ToString() + " é impar! portanto, o vencedor é: " + vencedor;
        }



    }



    public void SortearPC()
    {
        int numero = Random.Range(1, 101);
       
        pc_number.text = numero.ToString();
        
    }
}
