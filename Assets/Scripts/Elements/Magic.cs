using UnityEngine;

public class Magic : MonoBehaviour
{
    public GameObject element;
    Elements elementSelected;

    private void Start()
    {
        elementSelected = element.GetComponent<Elements>();
    }

    public void elementDescription()
    {
        Debug.Log("Elemento seleccionado: "+elementSelected.idName);
        Debug.Log("Velocidad: " + elementSelected.velocityMov);
        Debug.Log("Peso: " + elementSelected.weight);
    }
    public void launchElement()
    {
       
    }
}
