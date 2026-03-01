using UnityEngine;
using DG.Tweening;

/// <summary>
/// Повністю автономна 3D-анімація з DOTween без SerializedField.
/// Демонструє рух, обертання, масштабування, зміну кольору, ефекти "енергії" та "вибуху".
/// </summary>
public class Hero3DAnimation : MonoBehaviour
{
    private GameObject _hero;
    private GameObject _lightObj;
    private Light _light;
    private Material _mat;
    private Camera _cam;

    private void Start()
    {
        DOTween.Init();

        // --- 1️⃣ Створення героя ---
        _hero = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        _hero.transform.position = new Vector3(-5f, 0, 0);
        _hero.transform.localScale = Vector3.one * 1.5f;

        _mat = new Material(Shader.Find("Standard"));
        _mat.color = Color.gray;
        _hero.GetComponent<Renderer>().material = _mat;

        // --- 2️⃣ Додаємо світло ---
        _lightObj = new GameObject("AuraLight");
        _lightObj.transform.SetParent(_hero.transform);
        _lightObj.transform.localPosition = new Vector3(0, 2f, 0);
        _light = _lightObj.AddComponent<Light>();
        _light.type = LightType.Point;
        _light.color = Color.cyan;
        _light.intensity = 0f;
        _light.range = 6f;

        // --- 3️⃣ Камера ---
        _cam = Camera.main;
        if (_cam == null)
        {
            GameObject camObj = new GameObject("Main Camera");
            _cam = camObj.AddComponent<Camera>();
            _cam.transform.position = new Vector3(0, 2, -10);
            _cam.transform.LookAt(_hero.transform);
        }

        // --- 4️⃣ Запуск кінематографічної послідовності ---
        PlayCinematic();
    }

    private void PlayCinematic()
    {
        Sequence seq = DOTween.Sequence();

        // 1. Спокій перед пробудженням
        seq.Append(_hero.transform.DOScale(Vector3.one * 1.6f, 1f).SetEase(Ease.InOutSine).SetLoops(2, LoopType.Yoyo));

        // 2. Початок руху та пробудження
        seq.AppendCallback(() => Debug.Log("⚡ Герой пробуджується!"));
        seq.Append(_light.DOIntensity(3f, 1f));
        seq.Join(_mat.DOColor(Color.yellow, 1f));
        seq.Join(_hero.transform.DOMoveX(0f, 1.2f).SetEase(Ease.OutBack));

        // 3. Розворот із енергією
        seq.Append(_hero.transform.DORotate(new Vector3(0, 720, 0), 2f, RotateMode.FastBeyond360).SetEase(Ease.OutQuart));
        seq.Join(_hero.transform.DOScale(Vector3.one * 2f, 1.5f));
        seq.Join(_light.DOColor(Color.red, 1f));

        // 4. Енергетичний вибух
        seq.AppendCallback(() =>
        {
            Debug.Log("💥 Вибух енергії!");
            CreateShockwave(_hero.transform.position);
        });

        // 5. Камера shake
        seq.AppendCallback(() =>
        {
            _cam.DOShakePosition(1f, 0.6f, 15, 90, false);
        });

        // 6. Заспокоєння та фінальна поза
        seq.AppendInterval(0.5f);
        seq.Append(_hero.transform.DOMove(new Vector3(0, 0, 0), 1f).SetEase(Ease.InOutQuad));
        seq.Join(_hero.transform.DOScale(Vector3.one * 1.3f, 1f));
        seq.Join(_mat.DOColor(Color.white, 1.2f));
        seq.Join(_light.DOIntensity(0.8f, 1.2f));

        // 7. Кінець сцени
        seq.AppendCallback(() => Debug.Log("✅ Герой завершив пробудження."));
    }

    private void CreateShockwave(Vector3 position)
    {
        GameObject shock = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        shock.transform.position = position + Vector3.up * 0.5f;
        shock.transform.localScale = Vector3.zero;

        Material shockMat = new Material(Shader.Find("Standard"));
        shockMat.color = new Color(1f, 0.5f, 0f, 0.5f);
        shock.GetComponent<Renderer>().material = shockMat;

        shock.transform.DOScale(Vector3.one * 8f, 1.5f).SetEase(Ease.OutCubic);
        shockMat.DOColor(new Color(1f, 0.5f, 0f, 0f), 1.5f).OnComplete(() => Destroy(shock));
    }
}
