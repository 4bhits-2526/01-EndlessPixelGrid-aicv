using UnityEngine;
using UnityEngine.UI;

public class EndlessPixelUI : MonoBehaviour
{
    [SerializeField] private GameObject gridPanel;
    [SerializeField] private GameObject gridImg;

    [SerializeField] private GameObject inputPanel;
    [SerializeField] private GameObject inputImg;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 70; i++)
        {
            GameObject newImg = Instantiate(gridImg, gridPanel.transform);
            int row = (i / 7) + 1;
            int col = (i % 7) + 1;
            newImg.name = "img" + row + col;
        }

        for (int i = 0; i < 7; i++)
        {
            GameObject newInputImg = Instantiate(inputImg, inputPanel.transform);
            newInputImg.GetComponent<Image>().color = Color.black;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
