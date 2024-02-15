public class Word{
    private string _text;
    private bool _hidden = false;

    public Word(string text){
        _text = text;
    }

    public string WordToString()
    {
        return _text;
    }

    public string ShowWord(){
        return _text;
    }

    public void SetHidden(){
        _hidden = true;
    }

    public bool GetHidden(){
        return _hidden;
    }
}