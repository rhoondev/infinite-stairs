using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] float maxSliderValue;
    [SerializeField] float minSpeed;
    [SerializeField] float maxSpeed;
    [SerializeField] float maxDifficulty;

    float difficulty = 0f;

    void Start()
    {
        slider.minValue = 0f;
        slider.maxValue = maxSliderValue;
        slider.value = maxSliderValue / 2f;
    }

    void Update()
    {
        if (difficulty > 0)
        {
            slider.value -= Mathf.Lerp(minSpeed, maxSpeed, difficulty / maxDifficulty) * Time.deltaTime;
        }
    }

    public void IncreaseTimer()
    {
        slider.value++;
    }

    public void SetDifficulty(int difficulty)
    {
        this.difficulty = Mathf.Min(difficulty, maxDifficulty);
    }
}
