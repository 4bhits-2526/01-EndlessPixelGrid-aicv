using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject gridPanel;
    [SerializeField] private GameObject img;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Erstellen von 70 prefabs img in gridPanel
        // Wir loopen 70 mal (10 Reihen * 7 Spalten)
for (int i = 0; i < 70; i++)
{
    GameObject newImg = Instantiate(img, gridPanel.transform);

    // 2. Die Reihe berechnen (Integer Division)
    // (i / 7) ergibt 0 für die ersten 7, 1 für die nächsten 7 usw. 
    // +1 damit wir bei "1" anfangen zu zählen.
    int row = (i / 7) + 1;

    // 3. Die Spalte berechnen (Modulo Operator)
    // (i % 7) ergibt den Rest der Division (0, 1, 2... bis 6)
    // +1 damit wir von 1 bis 7 zählen statt 0 bis 6.
    int col = (i % 7) + 1;

    // 4. Den Namen setzen
    // Das Überschreiben von .name entfernt automatisch das "(Clone)"
    newImg.name = "img" + row + col;
}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
