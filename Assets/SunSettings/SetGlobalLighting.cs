using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;
public class SetGlobalLighting : MonoBehaviour
{
    [SerializeField] private SunSettingsSO[] m_sunSettings;
    private Light2D m_globalLight;

    void Start()
    {
        m_globalLight = GetComponent<Light2D>();
        m_globalLight.intensity = m_sunSettings[0].intensity;
        m_globalLight.color = m_sunSettings[0].colour;
        StartCoroutine(CycleSunSetttings());
    }

    IEnumerator CycleSunSetttings()
    {
        int currentSetting = 0;
        while (true)
        {
            currentSetting = (currentSetting + 1) % m_sunSettings.Length;
            m_globalLight.intensity = m_sunSettings[currentSetting].intensity;
            m_globalLight.color = m_sunSettings[currentSetting].colour;
            yield return new WaitForSeconds(5);
        }
    }
}
